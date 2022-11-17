﻿using Dapper;
using MISA.AMIS.Common.Entities;
using MISA.AMIS.Common.Enums;
using MISA.AMIS.Common.Interface;
using MISA.AMIS.Common.Models;
using MISA.AMIS.Common.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.AMIS.BL
{
    public class BaseService<MISAEntity> : IBaseService<MISAEntity>
    {
        #region Declare
        protected IDbContext<MISAEntity> dbconnection;
        string _tableName = typeof(MISAEntity).Name;
        ServiceResult _serviceResult;

        public IDbContext<Employee> Dbconnection { get; }
        #endregion

        #region Constructor
        public BaseService(IDbContext<MISAEntity> dbconnection)
        {
            this.dbconnection = dbconnection;
            _serviceResult = new ServiceResult();
        }
        #endregion

        #region Method
        public IEnumerable<MISAEntity> Get()
        {
            var sqlCommand = $"Proc_Get_{_tableName}";
            return dbconnection.Get(sqlCommand, null, System.Data.CommandType.StoredProcedure);
        }

        public virtual ServiceResult Insert(MISAEntity entity)
        {
            var parameters = MappingData(entity);
            Validator(entity);
            if (_serviceResult.MISACode == (int)MISACode.BadRequest)
            {
                return _serviceResult;
            }
            var sqlCommand = $"Proc_Insert_{_tableName}";
            var rowsAffected = dbconnection.ExcuteNonQuery(sqlCommand, parameters, System.Data.CommandType.StoredProcedure);
            if (rowsAffected > 0)
            {
                _serviceResult.Data = rowsAffected;
                _serviceResult.MISACode = (int)MISACode.Created;
                _serviceResult.userMsg = Resources.UserMsg_Insert_Created;
            }
            else if (rowsAffected == 0)
            {
                _serviceResult.Data = rowsAffected;
                _serviceResult.MISACode = (int)MISACode.Success;
                _serviceResult.userMsg = Resources.UserMsg_Insert_Success;
            }
            return _serviceResult;
        }

        public virtual ServiceResult Update(string entityId, MISAEntity entity)
        {
            var parameters = MappingData(entity);
            parameters.Add($"@{_tableName}Id", entityId);
            var sqlCommand = $"Proc_Update_{_tableName}";
            var rowsAffected = dbconnection.ExcuteNonQuery(sqlCommand, parameters, System.Data.CommandType.StoredProcedure);
            if (rowsAffected > 0)
            {
                _serviceResult.Data = rowsAffected;
                _serviceResult.MISACode = (int)MISACode.Success;
                _serviceResult.userMsg = Common.Properties.Resources.UserMsg_Update_Success;
            }
            else
            {
                _serviceResult.Data = rowsAffected;
                _serviceResult.MISACode = (int)MISACode.BadRequest;
                _serviceResult.userMsg = Common.Properties.Resources.UserMsg_Update_Fail;
            }
            return _serviceResult;
        }

        public ServiceResult Delete(string entityId)
        {
            var parameters = new DynamicParameters();
            parameters.Add($"@{_tableName}Id", entityId);
            var sqlCommand = $"Proc_Delete_{_tableName}";
            var rowsAffected = dbconnection.ExcuteNonQuery(sqlCommand, parameters, System.Data.CommandType.StoredProcedure);
            if (rowsAffected > 0)
            {
                _serviceResult.Data = rowsAffected;
                _serviceResult.MISACode = (int)MISACode.Success;
                _serviceResult.userMsg = MISA.AMIS.Common.Properties.Resources.UserMsg_Delete_Success;
            }
            else
            {
                _serviceResult.Data = rowsAffected;
                _serviceResult.MISACode = (int)MISACode.BadRequest;
                _serviceResult.userMsg = MISA.AMIS.Common.Properties.Resources.UserMsg_Delete_Fail;
            }
            return _serviceResult;
        }
        /// <summary>
        /// Hàm mapping data
        /// </summary>
        /// <returns></returns>
        /// CreatedBy: NhungDT(14/11/2022)
        private DynamicParameters MappingData(MISAEntity entity)
        {
            var parameter = new DynamicParameters();
            var properties = entity.GetType().GetProperties();
            foreach (var property in properties)
            {
                var propName = property.Name;
                var propValue = property.GetValue(entity);
                parameter.Add($"v_{propName}", propValue);
            }
            return parameter;
        }

        private void Validator(MISAEntity entity)
        {
            var properties = entity.GetType().GetProperties();
            foreach (var property in properties)
            {
                var propertyName = property.Name;
                var propertyValue = property.GetValue(entity);

                //Nếu property có attribute [Required] thì kiểm tra bắt buộc nhập
                if (property.IsDefined(typeof(Required), true)
                    && (propertyValue == null || propertyValue.ToString().Trim() == String.Empty))
                {
                    var requiredAttr = property.GetCustomAttributes(typeof(Required), true).FirstOrDefault();
                    if (requiredAttr != null)
                    {
                        var errMsg = (requiredAttr as Required).errorMsg;
                        _serviceResult.userMsg += $"{errMsg} ";
                        _serviceResult.MISACode = (int)MISACode.BadRequest;
                    }
                }
                else if (property.IsDefined(typeof(Duplicated), true))
                {
                    var dupliactedAttr = property.GetCustomAttributes(typeof(Duplicated), true).FirstOrDefault();
                    if (dupliactedAttr != null)
                    {
                        var errMsg = (dupliactedAttr as Duplicated).errorMsg;
                        var sqlCommand = $"SELECT {propertyName} FROM {_tableName} WHERE {propertyName} = '{propertyValue}'";
                        var obj = dbconnection.Get(sqlCommand, null, System.Data.CommandType.Text).FirstOrDefault();
                        if (obj != null)
                        {
                            _serviceResult.userMsg += $"{errMsg} ";
                            _serviceResult.MISACode = (int)MISACode.BadRequest;
                        }
                    }
                }
            }
        }

        public IEnumerable<Employee> Paging(Page page)
        {
            throw new NotImplementedException();
        }
        #endregion


    }
}
