using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Store.Common;

namespace Store.BusinessLogic
{
    public class Country
    {
        Store.DataAccessLayer.Country odlCountry = new DataAccessLayer.Country();
        public Store.BusinessObject.CountryList GetAllCountryList(int CountryID, int Flag, string FlagValue)
        {
            try
            {
                return odlCountry.GetAllCountryList(CountryID, Flag, FlagValue);
            }
            catch (Exception ex)
            {
                Store.Common.Utility.ExceptionLog.Exceptionlogs(ex.Message, Store.Common.Utility.ExceptionLog.LineNumber(ex), typeof(Country).FullName, 1);
                return null;
            }
        }public Store.BusinessObject.Country GetAllCountry(int CountryID, int Flag, string FlagValue)
        {
            try
            {
                return odlCountry.GetAllCountry(CountryID, Flag, FlagValue);
            }
            catch (Exception ex)
            {
                Store.Common.Utility.ExceptionLog.Exceptionlogs(ex.Message, Store.Common.Utility.ExceptionLog.LineNumber(ex), typeof(Country).FullName, 1);
                return null;
            }
        }
        public Store.Common.MessageInfo ManageItemMaster(Store.BusinessObject.Country objCountry, CommandMode cmdMode)
        {
            try
            {
                return odlCountry.ManageCountry(objCountry, cmdMode);
            }
            catch (Exception ex)
            {
                Store.Common.Utility.ExceptionLog.Exceptionlogs(ex.Message, Store.Common.Utility.ExceptionLog.LineNumber(ex), typeof(Country).FullName, 1);
                return null;
            }

        }
    }
}
