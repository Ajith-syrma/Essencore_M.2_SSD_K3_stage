using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Reflection;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace K1_Stages
{

    class DbConnection
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["conn"].ToString());
        SqlConnection con1 = new SqlConnection(ConfigurationManager.AppSettings["conn1"].ToString());
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        DataTable dt;
        public string DbConnect(string serial, string model, string capacity, string station,
                                string testTime, string status)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("pro_update_result_stat", con1))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@serial_no", serial);
                    cmd.Parameters.AddWithValue("@model", model);
                    cmd.Parameters.AddWithValue("@capacity", capacity);
                    cmd.Parameters.AddWithValue("@station", station);
                    cmd.Parameters.AddWithValue("@test_time", testTime);
                    cmd.Parameters.AddWithValue("@status", status); 

                    con1.Open();
                    object reader = cmd.ExecuteScalar();
                    con1.Close();

                    return reader?.ToString(); // handles null safely
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message); // ✅ show error
                return string.Empty;
            }
        }


        public string pcb_status(string serial, string model, string result)
        {
            try
            {
                cmd = new SqlCommand("pro_update_result_stat", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@serial", serial);
                cmd.Parameters.AddWithValue("@model", model);
                cmd.Parameters.AddWithValue("@result", result);
                //cmd.Parameters.AddWithValue("@Work_Orderno", Work_Orderno);
                con.Open();
                var reader = cmd.ExecuteScalar();
                con.Close();
                return reader.ToString();
            }
            catch (Exception ex)
            {
                return string.Empty;
                MessageBox.Show("Error : " + ex.Message.ToString());
            }
        }

        public string get_stage_valid(string serial, string model)
        {
            try
            {
                //cmd = new SqlCommand("pro_get_stage_val", con);
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@serial", serial);
                //cmd.Parameters.AddWithValue("@model", model);



                ////cmd.Parameters.AddWithValue("@result", result);
                ////cmd.Parameters.AddWithValue("@Work_Orderno", Work_Orderno);

                //con.Open();
                //var reader = cmd.ExecuteScalar();
                //con.Close();
                //return reader.ToString();
                return "Pass";
            }
            catch (Exception ex)
            {
                return string.Empty;
                MessageBox.Show("Error : " + ex.Message.ToString());
            }
        }


        public string get_serial_dup(string serial, string model)
        {
            try
            {
                cmd = new SqlCommand("pro_get_serial_dup", con1);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@serial_no", serial);
               // cmd.Parameters.AddWithValue("@model", model);
               //cmd.Parameters.AddWithValue("@result", result);
               //cmd.Parameters.AddWithValue("@Work_Orderno", Work_Orderno);
                con1.Open();
                var reader = cmd.ExecuteScalar();
                con1.Close();
                return reader.ToString();
                //return "Pass";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message.ToString());
                return string.Empty;
            }
        }
        public string getfgname(string serialno)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("pro_getfg_name", con1))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@serial_no", serialno);
                    con1.Open();
                    object reader = cmd.ExecuteScalar();
                    con1.Close();

                    return reader?.ToString(); // handles null safely
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message); // ✅ show error
                return string.Empty;
            }

        }

        public string getmodel(string fg)
        {
            try 
            {
                SqlCommand cmd = new SqlCommand("pro_getmodel_name", con1); 
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fg", fg);
                con1.Open();
                var result = cmd.ExecuteScalar();
                con1.Close();

                return result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message); 
                return string.Empty;
            }

        }

        public string getgentype(string fg)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pro_getgentype", con1);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fg", fg);
                con1.Open();
                var result = cmd.ExecuteScalar();
                con1.Close();

                return result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                return string.Empty;
            }

        }
        public List<Fgdetails> getfgdetails(string fgno)
        {
            var list = new List<Fgdetails>();
            try
            {

                Fgdetails objBar;
                cmd = new SqlCommand("pro_getfg_details", con1);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fg_name", fgno);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    objBar = new Fgdetails();
                    objBar.Firmware = Convert.ToString(dr["Firmware"]);
                    objBar.Model = Convert.ToString(dr["model"]);
                    objBar.Disksize = Convert.ToString(dr["disksize"]);
                    list.Add(objBar);
                }
                return list;
            }
            catch (Exception ex)
            {              
                MessageBox.Show("Error", "Database not connected");
                return list;
            }
        }

        public void uploadresult(List<QcDataRecord> records)
        {
            try
            {


                foreach (var record in records)
                {
                    using (SqlCommand cmd = new SqlCommand("pro_InsertQcData", con1))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@empid", record.emp_id);
                        cmd.Parameters.AddWithValue("@emp_name", record.emp_name);
                        cmd.Parameters.AddWithValue("@Fg_no", record.Fg_no);
                        cmd.Parameters.AddWithValue("@SerialNumber", record.SerialNumber);
                        cmd.Parameters.AddWithValue("@Firmware", record.Firmware);
                        cmd.Parameters.AddWithValue("@Temperature", record.Temperature);
                        cmd.Parameters.AddWithValue("@HealthStatus", record.HealthStatus);
                        cmd.Parameters.AddWithValue("@ModelNumber", record.ModelNumber);
                        cmd.Parameters.AddWithValue("@DriveLetter", record.DriveLetter);
                        cmd.Parameters.AddWithValue("@DiskSize", record.DiskSize);
                        cmd.Parameters.AddWithValue("@boardstatus", record.boardstatus);
                        con1.Open();
                        cmd.ExecuteNonQuery();
                        con1.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error uploading data: " + ex.Message);
            }
        }




        //public List<BarcodeDetails> GetBarcodeDetails(int labelid)
        //{
        //    var list = new List<BarcodeDetails>();
        //    try
        //    {

        //        BarcodeDetails objBar;
        //        cmd = new SqlCommand("pro_getPrintedValue", con);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@labelmasterid", labelid);
        //        adapter = new SqlDataAdapter(cmd);
        //        dt = new DataTable();
        //        adapter.Fill(dt);
        //        foreach (DataRow dr in dt.Rows)
        //        {
        //            objBar = new BarcodeDetails();
        //            objBar.CustomerSerialNo = Convert.ToString(dr["CustomerSerialNo"]);
        //            objBar.PCBSerialNo = Convert.ToString(dr["PCBSerialNo"]);
        //            objBar.ProductNo = Convert.ToString(dr["productno"]);
        //            list.Add(objBar);
        //        }
        //        return list;
        //    }
        //    catch (Exception ex)
        //    {
        //        return list;
        //        MessageBox.Show("Error", "Database not connected");
        //    }
        //}

        //public List<labeltype> GetLabels()
        //{
        //    var lstType = new List<labeltype>();
        //    try
        //    {

        //        labeltype objType = new labeltype();
        //        cmd = new SqlCommand("getLabelType", con);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        adapter = new SqlDataAdapter(cmd);
        //        dt = new DataTable();
        //        adapter.Fill(dt);
        //        foreach (DataRow dr in dt.Rows)
        //        {
        //            objType = new labeltype();
        //            objType.labelmasterid = Convert.ToInt32(dr["labelmasterid"]);
        //            objType.labelname = Convert.ToString(dr["labeltype"]);
        //            lstType.Add(objType);
        //        }
        //        return lstType;
        //    }
        //    catch (Exception ex)
        //    {
        //        return lstType;
        //        MessageBox.Show("Error :" + ex.Message.ToString());
        //    }

        //}

        public List<string> getcapacity(string stageval)
        {
            var listcapacity = new List<string>();
            try
            {
                
                cmd = new SqlCommand("pro_get_capacity_details", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@stage", stageval);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        listcapacity.Add(dr["capacity"].ToString());
                    }
                }
                return listcapacity;
            }
            catch (Exception ex)
            {
                return listcapacity;
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public string GetFilePathdetail(string stage,string capacity)
        {

            try
            {
                cmd = new SqlCommand("pro_getfilepath_k_stages", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@stage", stage);
                cmd.Parameters.AddWithValue("@Fg_Name", capacity);
                con.Open();
                var reader = cmd.ExecuteScalar();
                con.Close();
                return reader.ToString();
            }
            catch (Exception ex)
            {
                return string.Empty;
                MessageBox.Show("Error : " + ex.Message.ToString());
            }
        }
    }
}
