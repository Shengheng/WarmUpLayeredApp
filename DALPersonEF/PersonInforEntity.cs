using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;

namespace DALPersonEF
{
    public class PersonInforEntity
    {
        public void test()
        {
            using(var dbPerson = new demoEntities())
            {
                var PersonL = dbPerson.Person_long;

            }
        }
        /// <summary>
        /// Get result set of person whose age is greater than inupt Age from table Person_long 
        /// </summary>
        /// <param name="Age"></param>
        /// <param name="currentTime"></param>
        /// <returns></returns>
        public List<queryAge_Result> GetPersonLong(int Age, out string currentTime)
        {
            using(var dbPerson = new demoEntities())
            {
                var time = new ObjectParameter("CurrentTIme", typeof(DateTime));                 

                var lstResult = new List<queryAge_Result>();
                lstResult = dbPerson.queryAge(Age, time).ToList();
                currentTime = time.Value.ToString();
                return lstResult;
            }
        }

        /// <summary>
        /// Store the person information(Name, Age)into the Person_short table
        /// </summary>
        /// <param name="sp"></param>
        //public void SaveToPersonShort(List<queryAge_Result> lstPersonL, out int affRowNum)
        //{
        //    List<Person_short> lstPersonS = lstPersonL.SelectMany(s => s.FirstName, s.LastName).ToList();
        //    using(var dbPerson = new demoEntities())
        //    {
        //        var num = new ObjectParameter("num", typeof(int));

        //        dbPerson.pplPerson_short
        //    }
        //}
    }
}
