using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DALPersonEF;

namespace WcfServicePerson
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISvsPerson" in both code and config file together.
    [ServiceContract]
    public interface ISvsPerson
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        List<queryAge_Result> GetPersonLong(int Age, out string currentTime);

        //[OperationContract]
        //void SaveToPersonShort(List<queryAge_Result> lstPersonL, out int affRowNum);
    }
 
    //[DataContract]
    //public class SvsPersonLong
    //{
    //    [DataMember]
    //    public string FirstName { get; set; }
    //    [DataMember]
    //    public string LastName { get; set; }
    //    [DataMember]
    //    public string City { get; set; }
    //    [DataMember]
    //    public string PhoneNumber { get; set; }
    //    [DataMember]
    //    public int Age { get; set; }
    //}
    //[DataContract]
    //public class SvsPersonShort
    //{
    //    [DataMember]
    //    public string Name { get; set; }
    //    [DataMember]
    //    public int Age { get; set; }
    //}
}
