using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AaronMorris_C969_Task1.Models
{
    static class globals
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["ClientDatabase"].ConnectionString;

        public static BindingList<Customer> CustomerList = new BindingList<Customer>();

        public static BindingList<User> UserList = new BindingList<User>();

        //internal static Address GetAddressById(int addressId)
        //{
        //    return AddressList.Where(addr => addr.addressId == addressId).First();
        //}

        public static BindingList<Appointment> AppointmentList = new BindingList<Appointment>();

        public static BindingList<Address> AddressList = new BindingList<Address>();

        public static BindingList<City> CityList = new BindingList<City>();

        internal static Customer GetCustomerById(int customerId)
        {
            //lambda expression to return Customer from CustomerList
            return CustomerList.Where(cust => cust.customerId == customerId).First();
        }

        public static BindingList<Country> CountryList = new BindingList<Country>();

        public static bool countryExists = false;
        public static bool cityExists = false;
        public static bool addressExists = false;
       

        public static void GetAllInfo()
        {

            for (int i = 0; i < 6; i++)
            {
                String dataType;
                //List<Object> itemList = new List<object>();

                if (i == 0) { dataType = "appointment"; }
                else if (i == 1) { dataType = "customer"; }
                else if (i == 2) { dataType = "user"; }
                else if (i == 3) { dataType = "address"; }
                else if (i == 4) { dataType = "city"; }
                else if (i == 5) { dataType = "country"; }
                else
                {
                    dataType = null;
                }

                MySqlConnection con = new MySqlConnection(connectionString);

                con.Open();

                string sqlString = @"SELECT * FROM " + dataType + ";";
                MySqlCommand cmd = new MySqlCommand(sqlString, con);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataTable InfoTable = new DataTable();
                adp.Fill(InfoTable);

                foreach (DataRow row in InfoTable.Rows)
                {
                    if (i == 0)
                    {
                        Appointment incomingData = new Appointment();

                        incomingData.appointmentId = row.Field<int>("appointmentId");
                        incomingData.customerId = row.Field<int>("customerId");
                        incomingData.userId = row.Field<int>("userId");
                        incomingData.title = row.Field<string>("title");
                        incomingData.description = row.Field<string>("description");
                        incomingData.location = row.Field<string>("location");
                        incomingData.type = row.Field<string>("type");
                        incomingData.start = row.Field<DateTime>("start").ToLocalTime();
                        incomingData.end = row.Field<DateTime>("end").ToLocalTime();

                        AppointmentList.Add(incomingData);

                    }

                    if (i == 1)
                    {
                        Customer incomingData = new Customer();

                        incomingData.active = row.Field<bool>("active");
                        incomingData.customerId = row.Field<int>("customerId");
                        incomingData.customerName = row.Field<string>("customerName");
                        incomingData.addressId = row.Field<int>("addressId");

                        CustomerList.Add(incomingData);
                    }

                    if (i == 2)
                    {
                        User incomingData = new User();

                        incomingData.userId = row.Field<int>("userId");
                        incomingData.userName = row.Field<string>("userName");
                        incomingData.password = row.Field<string>("password");
                        incomingData.active = Convert.ToBoolean(row.Field<sbyte>("active"));

                        UserList.Add(incomingData);
                    }

                    if (i == 3)
                    {
                        Address incomingData = new Address();

                        incomingData.addressId = row.Field<int>("addressId");
                        incomingData.address = row.Field<string>("address");
                        incomingData.address2 = row.Field<string>("address2");
                        incomingData.postalCode = row.Field<string>("postalCode");
                        incomingData.phone = row.Field<string>("phone");
                        incomingData.cityId = row.Field<int>("cityId");

                        AddressList.Add(incomingData);
                    }

                    if (i == 4)
                    {
                        City incomingData = new City();

                        incomingData.cityId = row.Field<int>("cityId");
                        incomingData.name = row.Field<string>("city");
                        incomingData.countryId = row.Field<int>("countryId");

                        CityList.Add(incomingData);
                    }

                    if (i == 5)
                    {
                        Country incomingData = new Country();

                        incomingData.countryId = row.Field<int>("countryId");
                        incomingData.name = row.Field<string>("country");

                        CountryList.Add(incomingData);
                    }

                }
            }
        }

        #region Adding, updating, and deleting users, customers, appointments, addresses, cities, and countries.
        public static void AddUser(User user) {

            string insertStatement = @"INSERT INTO `user`
                                    (`userId`,
                                    `userName`,
                                    `password`,
                                    `active`,
                                    `createDate`,
                                    `createdBy`,
                                    `lastUpdate`,
                                    `lastUpdateBy`)
                                    VALUES
                                    (@userid,
                                    @username,
                                    @password,
                                    @active,
                                    @createDate,
                                    @createdBy,
                                    @lastUpdate,
                                    @lastUpdateBy);";

           
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = insertStatement;
            comm.Parameters.AddWithValue("@userid", user.userId);
            comm.Parameters.AddWithValue("@username", user.userName);
            comm.Parameters.AddWithValue("@password", user.password);
            comm.Parameters.AddWithValue("@active", user.active); 
            comm.Parameters.AddWithValue("@createDate", System.DateTime.UtcNow);
            comm.Parameters.AddWithValue("@createdBy", currentUser.userName); 
            comm.Parameters.AddWithValue("@lastUpdate", System.DateTime.UtcNow);
            comm.Parameters.AddWithValue("@lastUpdateBy", currentUser.userName);
            comm.ExecuteNonQuery();
            conn.Close();
        }
        public static void UpdateUser(User user) {

            string updateStatement = @"UPDATE `user`
                                        SET
                                        `userName` = @username,
                                        `password` = @password,
                                        `active` = @active,
                                        `lastUpdate` = @lastUpdate,
                                        `lastUpdateBy` = @lastUpdateBy
                                        WHERE userId = @userId;
                                        ";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = updateStatement;
            comm.Parameters.AddWithValue("@userid", user.userId);
            comm.Parameters.AddWithValue("@username", user.userName);
            comm.Parameters.AddWithValue("@password", user.password);
            comm.Parameters.AddWithValue("@active", user.active);
            comm.Parameters.AddWithValue("@lastUpdate", System.DateTime.UtcNow);
            comm.Parameters.AddWithValue("@lastUpdateBy", currentUser.userName);
            comm.ExecuteNonQuery();
            conn.Close();

        }
        public static void DeleteUser(User user)
        {

            //TODO if user is assigned to appointment, then don't allow delete

            string deleteStatement = @"DELETE FROM `user`
                                    WHERE userId= @userId;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = deleteStatement;
            comm.Parameters.AddWithValue("@userid", user.userId);
            comm.ExecuteNonQuery();
            conn.Close();
        }

        public static void AddCustomer(Customer customer) {

            string insertStatement = @"INSERT INTO `customer`
                                    (`customerId`,
                                    `customerName`,
                                    `addressId`,
                                    `active`,
                                    `createDate`,
                                    `createdBy`,
                                    `lastUpdate`,
                                    `lastUpdateBy`)
                                    VALUES
                                    (@customerId,
                                    @customerName,
                                    @addressId,
                                    @active,
                                    @createDate,
                                    @createdBy,
                                    @lastUpdate,
                                    @lastUpdateBy);";

            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = insertStatement;
            comm.Parameters.AddWithValue("@customerId", customer.customerId);
            comm.Parameters.AddWithValue("@customerName", customer.customerName);
            comm.Parameters.AddWithValue("@addressId", customer.addressId);
            comm.Parameters.AddWithValue("@active", customer.active);
            comm.Parameters.AddWithValue("@createDate", System.DateTime.UtcNow);
            comm.Parameters.AddWithValue("@createdBy", currentUser.userName);
            comm.Parameters.AddWithValue("@lastUpdate", System.DateTime.UtcNow);
            comm.Parameters.AddWithValue("@lastUpdateBy", currentUser.userName);
            comm.ExecuteNonQuery();
            conn.Close();

        }
        public static void UpdateCustomer(Customer customer) {

            string updateStatement = @"UPDATE `customer`
                                    SET
                                    `customerId` = @customerId,
                                    `customerName` = @customerName,
                                    `addressId` = @addressId,
                                    `active` = @active,
                                    `lastUpdate` = @lastUpdate,
                                    `lastUpdateBy` = @lastUpdateBy
                                    WHERE customerId = @customerId;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = updateStatement;
            comm.Parameters.AddWithValue("@customerid", customer.customerId);
            comm.Parameters.AddWithValue("@customerName", customer.customerName);
            comm.Parameters.AddWithValue("@addressId", customer.addressId);
            comm.Parameters.AddWithValue("@active", customer.active);
            comm.Parameters.AddWithValue("@lastUpdate", System.DateTime.UtcNow);
            comm.Parameters.AddWithValue("@lastUpdateBy", currentUser.userName);
            comm.ExecuteNonQuery();
            conn.Close();

        }
        public static void DeleteCustomer(Customer customer) {

            string deleteStatement = @"DELETE FROM `customer`
                                     WHERE customerId= @customerId;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = deleteStatement;
            comm.Parameters.AddWithValue("@customerId", customer.customerId);
            comm.ExecuteNonQuery();
            conn.Close();

        }
        public static void AddAppointment(Appointment appointment) {

            string insertStatement = @"INSERT INTO `appointment`
                                   (`appointmentId`,
                                    `customerId`,
                                    `userId`,
                                    `title`,
                                    `description`,
                                    `location`,
                                    `contact`,
                                    `type`,
                                    `url`,
                                    `start`,
                                    `end`,
                                    `createDate`,
                                    `createdBy`,
                                    `lastUpdate`,
                                    `lastUpdateBy`)
                                    VALUES
                                    (@appointmentId,
                                    @customerId,
                                    @userId,
                                    @title,
                                    @description,
                                    @location,
                                    @contact,
                                    @type,
                                    @url,
                                    @start,
                                    @end,
                                    @createDate,
                                    @createdBy,
                                    @lastUpdate,
                                    @lastUpdateBy);";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = insertStatement;
            comm.Parameters.AddWithValue("@appointmentId", appointment.appointmentId);
            comm.Parameters.AddWithValue("@customerId", appointment.customerId);
            comm.Parameters.AddWithValue("@userId", appointment.userId);
            comm.Parameters.AddWithValue("@title", appointment.title);
            comm.Parameters.AddWithValue("@description", appointment.description);
            comm.Parameters.AddWithValue("@location", appointment.location);
            comm.Parameters.AddWithValue("@type", appointment.type);
            comm.Parameters.AddWithValue("@contact", "None");
            comm.Parameters.AddWithValue("@url", "None");
            comm.Parameters.AddWithValue("@start", appointment.start.ToUniversalTime());
            comm.Parameters.AddWithValue("@end", appointment.end.ToUniversalTime());
            comm.Parameters.AddWithValue("@createDate", System.DateTime.UtcNow);
            comm.Parameters.AddWithValue("@createdBy", currentUser.userName);
            comm.Parameters.AddWithValue("@lastUpdate", System.DateTime.UtcNow);
            comm.Parameters.AddWithValue("@lastUpdateBy", currentUser.userName);
            comm.ExecuteNonQuery();
            conn.Close();

        }
        public static void UpdateAppointment(Appointment appointment) {

            string updateStatement = @"UPDATE `appointment`
                                    SET
                                    `appointmentId` = @appointmentId,
                                    `customerId` = @customerId,
                                    `userId` = @userId,
                                    `title` = @title,
                                    `description` = @description,
                                    `location` = @location,
                                    `type` = @type,
                                    `start` = @start,
                                    `end` = @end,
                                    `lastUpdate` = @lastUpdate,
                                    `lastUpdateBy` = @lastUpdateBy
                                    WHERE appointmentId = @appointmentId;
                                    ";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = updateStatement;
            comm.Parameters.AddWithValue("@appointmentId", appointment.appointmentId);
            comm.Parameters.AddWithValue("@customerId", appointment.customerId);
            comm.Parameters.AddWithValue("@userId", appointment.userId);
            comm.Parameters.AddWithValue("@title", appointment.title);
            comm.Parameters.AddWithValue("@description", appointment.description);
            comm.Parameters.AddWithValue("@location", appointment.location);
            comm.Parameters.AddWithValue("@type", appointment.type);
            comm.Parameters.AddWithValue("@start", appointment.start.ToUniversalTime());
            comm.Parameters.AddWithValue("@end", appointment.end.ToUniversalTime());
            comm.Parameters.AddWithValue("@lastUpdate", System.DateTime.UtcNow);
            comm.Parameters.AddWithValue("@lastUpdateBy", currentUser.userName);
            comm.ExecuteNonQuery();
            conn.Close();
        }
        public static void DeleteAppointment(Appointment appointment) {

            string deleteStatement = @"DELETE FROM `appointment`
                                    WHERE appointmentId = @appointmentId;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = deleteStatement;
            comm.Parameters.AddWithValue("@appointmentId", appointment.appointmentId);
            comm.ExecuteNonQuery();
            conn.Close();
        }
        public static void AddAddress(Address address) {

            string insertStatement = @"INSERT INTO `address`
                                    (`addressId`,
                                    `address`,
                                    `address2`,
                                    `cityId`,
                                    `postalCode`,
                                    `phone`,
                                    `createDate`,
                                    `createdBy`,
                                    `lastUpdate`,
                                    `lastUpdateBy`)
                                    VALUES
                                    (@addressId,
                                    @address,
                                    @address2,
                                    @cityId,
                                    @postalCode,
                                    @phone,
                                    @createDate,
                                    @createdBy,
                                    @lastUpdate,
                                    @lastUpdateBy);
                                    ";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = insertStatement;
            comm.Parameters.AddWithValue("@addressId", address.addressId);
            comm.Parameters.AddWithValue("@address", address.address);
            comm.Parameters.AddWithValue("@address2", address.address2);
            comm.Parameters.AddWithValue("@cityId", address.cityId);
            comm.Parameters.AddWithValue("@postalCode", address.postalCode);
            comm.Parameters.AddWithValue("@phone", address.phone);
            comm.Parameters.AddWithValue("@createDate", System.DateTime.UtcNow);
            comm.Parameters.AddWithValue("@createdBy", currentUser.userName);
            comm.Parameters.AddWithValue("@lastUpdate", System.DateTime.UtcNow);
            comm.Parameters.AddWithValue("@lastUpdateBy", currentUser.userName);
            comm.ExecuteNonQuery();
            conn.Close();
        }
        public static void UpdateAddress(Address address) {

            string updateStatement = @"UPDATE `address`
                                    SET
                                    `addressId` = @addressId,
                                    `address` = @address,
                                    `address2` = @address2,
                                    `cityId` = @cityId,
                                    `postalCode` = @postalCode,
                                    `phone` = @phone,
                                    `lastUpdate` = @lastUpdate,
                                    `lastUpdateBy` = @lastUpdateBy
                                    WHERE addressId = @addressId;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = updateStatement;
            comm.Parameters.AddWithValue("@addressId", address.addressId);
            comm.Parameters.AddWithValue("@address", address.address);
            comm.Parameters.AddWithValue("@address2", address.address2);
            comm.Parameters.AddWithValue("@cityId", address.cityId);
            comm.Parameters.AddWithValue("@postalCode", address.postalCode);
            comm.Parameters.AddWithValue("@phone", address.phone);
            comm.Parameters.AddWithValue("@lastUpdate", System.DateTime.UtcNow);
            comm.Parameters.AddWithValue("@lastUpdateBy", currentUser.userName);
            comm.ExecuteNonQuery();
            conn.Close();
        }
        public static void DeleteAddress(Address address)
        {

            string deleteStatement = @"DELETE FROM `address`
                                    WHERE addressId = @addressId;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = deleteStatement;
            comm.Parameters.AddWithValue("@addressId", address.addressId);
            comm.ExecuteNonQuery();
            conn.Close();
        }
        public static void AddCity(City city) {

            string insertStatement = @"INSERT INTO `city`
                                    (`cityId`,
                                    `city`,
                                    `countryId`,
                                    `createDate`,
                                    `createdBy`,
                                    `lastUpdate`,
                                    `lastUpdateBy`)
                                    VALUES
                                    (@cityId,
                                    @city,
                                    @countryId,
                                    @createDate,
                                    @createdBy,
                                    @lastUpdate,
                                    @lastUpdateBy);";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = insertStatement;
            comm.Parameters.AddWithValue("@cityId", city.cityId);
            comm.Parameters.AddWithValue("@city", city.name);
            comm.Parameters.AddWithValue("@countryId", city.countryId);
            comm.Parameters.AddWithValue("@createDate", System.DateTime.UtcNow);
            comm.Parameters.AddWithValue("@createdBy", currentUser.userName);
            comm.Parameters.AddWithValue("@lastUpdate", System.DateTime.UtcNow);
            comm.Parameters.AddWithValue("@lastUpdateBy", currentUser.userName);
            comm.ExecuteNonQuery();
            conn.Close();
        }
        public static void UpdateCity(City city) {

            string updateStatement = @"UPDATE `city`
                                    SET
                                    `cityId` = @cityId,
                                    `city` = @city,
                                    `countryId` = @countryId,
                                    `lastUpdate` = @lastUpdate,
                                    `lastUpdateBy` = @lastUpdateBy
                                    WHERE cityId = @cityId;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = updateStatement;
            comm.Parameters.AddWithValue("@cityId", city.cityId);
            comm.Parameters.AddWithValue("@city", city.name);
            comm.Parameters.AddWithValue("@countryId", city.countryId);
            comm.Parameters.AddWithValue("@lastUpdate", System.DateTime.UtcNow);
            comm.Parameters.AddWithValue("@lastUpdateBy", currentUser.userName);
            comm.ExecuteNonQuery();
            conn.Close();
        }
        public static void DeleteCity(City city) {

            string deleteStatement = @"DELETE FROM `city`
                                    WHERE cityId = @cityId;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = deleteStatement;
            comm.Parameters.AddWithValue("@cityId", city.cityId);
            comm.ExecuteNonQuery();
            conn.Close();
        }
        public static void AddCountry(Country country) {

            string insertStatement = @"INSERT INTO `country`
                                    (`countryId`,
                                    `country`,
                                    `createDate`,
                                    `createdBy`,
                                    `lastUpdate`,
                                    `lastUpdateBy`)
                                    VALUES
                                    (@countryId,
                                    @country,
                                    @createDate,
                                    @createdBy,
                                    @lastUpdate,
                                    @lastUpdateBy);";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = insertStatement;
            comm.Parameters.AddWithValue("@country", country.name);
            comm.Parameters.AddWithValue("@countryId", country.countryId);
            comm.Parameters.AddWithValue("@createDate", System.DateTime.UtcNow);
            comm.Parameters.AddWithValue("@createdBy", currentUser.userName);
            comm.Parameters.AddWithValue("@lastUpdate", System.DateTime.UtcNow);
            comm.Parameters.AddWithValue("@lastUpdateBy", currentUser.userName);
            comm.ExecuteNonQuery();
            conn.Close();
        }
        public static void UpdateCountry(Country country) {

            string updateStatement = @"UPDATE `country`
                                    SET
                                    `countryId` = @countryId,
                                    `country` = @country,
                                    `lastUpdate` = @lastUpdate,
                                    `lastUpdateBy` = @lastUpdateBy
                                    WHERE countryId = @countryId;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = updateStatement;
            comm.Parameters.AddWithValue("@countryId", country.countryId);
            comm.Parameters.AddWithValue("@country", country.name);
            comm.Parameters.AddWithValue("@lastUpdate", System.DateTime.UtcNow);
            comm.Parameters.AddWithValue("@lastUpdateBy", currentUser.userName);
            comm.ExecuteNonQuery();
            conn.Close();
        }
        public static void DeleteCountry(Country country) {

            string deleteStatement = @"DELETE FROM `country`
                                    WHERE countryId = @countryId;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = deleteStatement;
            comm.Parameters.AddWithValue("@countryId", country.countryId);
            comm.ExecuteNonQuery();
            conn.Close();
        }
        #endregion

        internal static User GetUserById(int userId)
        {
            //lambda expression to return user from UserList
            return UserList.Where(user => user.userId == userId).First();
        }

        public static int currentIndexSelected = -1;

        public static User currentUser = null;
        public static Customer currentCustomer = null;
        public static City currentCity = null;
        public static Country currentCountry= null;
        public static Address currentAddress = null;
        public static Appointment currentAppointment = null;

        public static void ResetSelections()
        {
            currentIndexSelected = -1;

            currentCustomer = null;
            currentCity = null;
            currentCountry= null;
            currentAddress = null;
            currentAppointment = null;
        }

        public static bool BetweenDates(DateTime timeTocheck, DateTime startTime, DateTime endTime)
        {
            return (timeTocheck > startTime && timeTocheck < endTime);
        }

        public static bool BetweenTimes(TimeSpan timeTocheck, TimeSpan startTime, TimeSpan endTime)
        {
            return (timeTocheck > startTime && timeTocheck < endTime);
        }
    }
}
