using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DALPersonEF;

namespace WcfServicePerson
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SvsPerson" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SvsPerson.svc or SvsPerson.svc.cs at the Solution Explorer and start debugging.
    public class SvsPerson : ISvsPerson
    {
        public void DoWork()
        {
        }

       /// <summary>
       /// EF
       /// </summary>
       /// <param name="Age"></param>
       /// <param name="currentTime"></param>
       /// <returns></returns>
        public List<queryAge_Result> GetPersonLong(int Age, out string currentTime)
        {
            string time;
            PersonInforEntity PersonInfor = new PersonInforEntity();
            List<queryAge_Result> lstPersonLong = PersonInfor.GetPersonLong(Age, out time);
            currentTime = time;
            return lstPersonLong;
        }

        //public List<PeronLong> GetPersonLong(int Age, out string currentTime)
        //{
        //    string time;
        //    DALPerson.PersonInfor PersonInfor = new DALPerson.PersonInfor();
        //    List<SvsPersonLong> lstPersonLong = PersonInfor.GetPersonLong(Age, out time);
        //    currentTime = time;
        //    return lstPersonLong;
        //}

        //public void SaveToPersonShort(List<PersonLong> lstPersonL, out int affRowNum)
        //{
        //    //int count;
        //    //DALPerson.PersonInfor PersonInfor = new DALPerson.PersonInfor();
        //    //PersonInfor.SaveToPersonShort(lstPersonL, out count);
        //    //affRowNum = count;
        //}
    }
}
