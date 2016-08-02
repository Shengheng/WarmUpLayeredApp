using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using EntityPerson;

namespace DALPerson
{
    public class PersonInfor
    {
        /// <summary>
        /// Get result set of person whose age is greater than inupt Age from table Person_long 
        /// </summary>
        /// <param name="Age"></param>
        /// <param name="currentTime"></param>
        /// <returns></returns>
        public List<PersonLong> GetPersonLong(int Age, out string currentTime)
        {
            List<PersonLong> lstPeronLong = new List<PersonLong>();
            string cntStr = ConfigurationManager.ConnectionStrings["cntDemo"].ConnectionString;
            using(SqlConnection scnt = new SqlConnection(cntStr))
            {
                SqlCommand sc = new SqlCommand("queryAge", scnt);
                sc.CommandType = CommandType.StoredProcedure;
                // input parameters
                sc.Parameters.AddWithValue("@Age", Age);
                // output parameters
                SqlParameter paraOut = sc.Parameters.Add("@CurrentTime", SqlDbType.DateTime);
                paraOut.Direction = ParameterDirection.Output;

                #region TRY
                try
                {
                    scnt.Open();
                    SqlDataReader sdr = sc.ExecuteReader();
                    //read and stored the queried set into output list
                    while(sdr.Read())
                    {
                        lstPeronLong.Add(new PersonLong() {
                            FirstName = sdr[0].ToString(), LastName = sdr[1].ToString(),
                            City = sdr[2].ToString(), PhoneNumber = sdr[3].ToString(),
                            Age = Convert.ToInt32(sdr[4])
                        });
                    }
                    sdr.Close();
                }
                catch(Exception e)
                {
                }
                finally
                {
                    currentTime = paraOut.Value.ToString();
                }
                #endregion
            }
            return lstPeronLong;
        }

        /// <summary>
        /// Store the person information(Name, Age)into the Person_short table
        /// </summary>
        /// <param name="sp"></param>
        public void SaveToPersonShort(List<PersonLong> lstPersonL, out int affRowNum)
        {
            List<PersonShort> lstPersonS = new List<PersonShort>();
            foreach(var item in lstPersonL)
            {
                lstPersonS.Add(new PersonShort { Name = item.FirstName + "," + item.LastName, Age = item.Age });
            }

            affRowNum = 0;
            string cntStr = ConfigurationManager.ConnectionStrings["cntDemo"].ConnectionString;
            using(SqlConnection scnt = new SqlConnection(cntStr))
            {
                SqlCommand sc = new SqlCommand("pplPerson_short", scnt);
                sc.CommandType = CommandType.StoredProcedure;
                SqlParameter paraInName = sc.Parameters.Add("@Name", SqlDbType.VarChar, 50);
                paraInName.Direction = ParameterDirection.Input;
                SqlParameter paraInAge = sc.Parameters.Add("@Age", SqlDbType.Int);
                paraInAge.Direction = ParameterDirection.Input;
                #region Try
                try
                {
                    scnt.Open();
                    foreach(var item in lstPersonS)
                    {
                        paraInName.SqlValue = item.Name;
                        paraInAge.SqlValue = item.Age;
                        affRowNum += sc.ExecuteNonQuery();
                    }
                }
                catch(Exception e)
                {
                }
                finally
                {
                }
                #endregion
            }
        }
    }
}

