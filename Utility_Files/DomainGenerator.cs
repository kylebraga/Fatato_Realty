using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication3.Class_Files;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace WebApplication3
{
    public class DomainGenerator
    {

        public int typeId;
        public string typeName;
        public string typeDesc;
     

        public DomainGenerator()
        {
            DomainContext.CardIconTypeList = new ArrayList();
            DomainContext.FurnishedTypeList = new ArrayList();
            DomainContext.CommercialPropertyTypeList = new ArrayList();
            DomainContext.LaundryTypeList = new ArrayList();
            DomainContext.ParkingTypeList = new ArrayList();
            DomainContext.PropertyTypeList = new ArrayList();
            DomainContext.ResidentialPropertyTypeList = new ArrayList();
            DomainContext.SmokingTypeList = new ArrayList();
        }

        public void DomainManager()
        {
            MakeDBCalls(DomainContext.AvailabiltyTypeTableName, DomainContext.AvailabilityTypeList, DomainContext.noDescription);
            MakeDBCalls(DomainContext.CardIconTypeTableName, DomainContext.CardIconTypeList, DomainContext.hasDescription);
            MakeDBCalls(DomainContext.CommercialPropertyTypeTableName, DomainContext.CommercialPropertyTypeList, DomainContext.noDescription);
            MakeDBCalls(DomainContext.LaundryTypeTableName, DomainContext.LaundryTypeList, DomainContext.noDescription);
            MakeDBCalls(DomainContext.ParkingTypeTableName, DomainContext.ParkingTypeList, DomainContext.noDescription);
            MakeDBCalls(DomainContext.PropertyTypeTableName, DomainContext.PropertyTypeList, DomainContext.noDescription);
            MakeDBCalls(DomainContext.ResidentialPropertyTypeTableName, DomainContext.ResidentialPropertyTypeList, DomainContext.noDescription);
            MakeDBCalls(DomainContext.SmokingTypeTableName, DomainContext.SmokingTypeList, DomainContext.noDescription);
        }

        public void MakeDBCalls(string tableName, ArrayList currentList, int index)
        {
            string tempName;
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Server= localhost\\SQLEXPRESS;Database= Fato_Realty_DB;Trusted_Connection=true";
                conn.Open();

                SqlCommand command = new SqlCommand((String.Format("SELECT * FROM {0}", tableName)), conn);

                SqlDataReader reader = null;
                reader = command.ExecuteReader();
                if (!reader.HasRows.Equals(false))
                {

                    while (reader.Read())
                    {
                        tempName = (String.Format("{0}", reader[index]));
                        currentList.Add(tempName);
                    }
                }
            }
        }

        private void Domain_Factory(SqlDataReader reader)
        {
            while (reader.Read())
            {
                GlobalContext.CurrentUser.userId = Int32.Parse((String.Format("{0}", reader[0])));
                GlobalContext.CurrentUser.userEmail = (String.Format("{0}", reader[1]));
                GlobalContext.CurrentUser.passWord = (String.Format("{0}", reader[2]));
                GlobalContext.CurrentUser.isAdmin = (Boolean.Parse(String.Format("{0}", reader[3])));
                GlobalContext.CurrentUser.firstName = (String.Format("{0}", reader[4]));
                GlobalContext.CurrentUser.middleName = (String.Format("{0}", reader[5]));
                GlobalContext.CurrentUser.lastName = (String.Format("{0}", reader[6]));
                //MyGlobalContext.currentUser.dateCreated = (DateTime.Parse(String.Format("{0}", reader[7])));
                //MyGlobalContext.currentUser.lastLogin = (DateTime.Parse(String.Format("{0}", reader[8])));
            }

        }
        





    }
}