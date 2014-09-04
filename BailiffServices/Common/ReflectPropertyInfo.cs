using System;
using System.Data;
using System.Reflection;

using Common.Attributes;

namespace Common
{
    /// <summary>
    /// Class that will map the public properties of a .NET class to the columns in a DataReader.
    /// For example mapping Customer class properties to a SQL DataReader column names.
    /// This is achieved using .NET Reflection and the custom class DataFieldAttribute which is used
    /// to decorate the .NET class properties with the corresponding DataReader column name.
    /// If you don't understand Reflection then do NOT amend this code!
    /// </summary>
    /// <example>See the class definition for DebtorEntity and the implementation for DebtorData.GetDebtorInfo() as an example.</example>
    public static class ReflectPropertyInfo
    {
        public static TEntity ReflectType<TEntity>(IDataReader dr) where TEntity : class, new()
        {
            TEntity instanceToPopulate = new TEntity();

            PropertyInfo[] propertyInfos = typeof(TEntity).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            //for each public property on the original
            foreach (PropertyInfo pi in propertyInfos)
            {
                DataFieldAttribute[] datafieldAttributeArray = pi.GetCustomAttributes(typeof(DataFieldAttribute), false) as DataFieldAttribute[];

                //this attribute is marked with AllowMultiple=false
                if (datafieldAttributeArray != null && datafieldAttributeArray.Length == 1)
                {
                    DataFieldAttribute dfa = datafieldAttributeArray[0];

                    //this will blow up if the datareader does not contain the item keyed dfa.Name
                    object dbValue = dr[dfa.Name];

                    if (dbValue != null)
                    {
                        pi.SetValue(instanceToPopulate, Convert.ChangeType(dbValue, pi.PropertyType), null);
                    }
                }
            }
            
            return instanceToPopulate;
        }
    }
}
