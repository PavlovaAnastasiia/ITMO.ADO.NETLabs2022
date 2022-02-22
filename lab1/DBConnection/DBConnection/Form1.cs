﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace DBConnection
{
    public partial class Form1 : Form
    {
        OleDbConnection connection = new OleDbConnection();
        //string testConnect = @"Provider=SQLOLEDB.1;
        //Integrated Security=SSPI;Persist Security Info=False;
        //Initial Catalog=Northwind;Data Source=(local)";

        string testConnect = GetConnectionStringByName("DBConnect.NorthwindConnectionString");

        public Form1()
        {
            InitializeComponent();
            this.connection.StateChange += new
            System.Data.StateChangeEventHandler(
            this.connection_StateChange);
        }
        private void connection_StateChange(object sender, System.Data.StateChangeEventArgs e)
        {
            MenuItemConnect.Enabled =
                (e.CurrentState == ConnectionState.Closed);
            MenuDisconnect.Enabled =
                (e.CurrentState == ConnectionState.Open);
        }
        static string GetConnectionStringByName(string name)
        {
            string returnValue = null;
            ConnectionStringSettings settings =
                ConfigurationManager.ConnectionStrings[name];
            if (settings != null)
                returnValue = settings.ConnectionString;
            return returnValue;
        }
    
        private void MenuItemConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = testConnect;
                    connection.Open();
                    MessageBox.Show("Соединение с базой данных выполнено успешно");
                }
                else
                    MessageBox.Show("Соединение с базой данных уже установлено");
            }
            //catch
            //{
            //    MessageBox.Show("Ошибка соединения с базой данных");
            //}
            catch (OleDbException XcpSQL)
            {
                foreach (OleDbError se in XcpSQL.Errors)
                {
                    MessageBox.Show(se.Message,
                    "SQL Error code " + se.NativeError);
                }
            }
            catch (Exception Xcp)
            {
                MessageBox.Show(Xcp.Message, "Unexpected Exception");
            }
        }

        private void MenuDisconnect_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Соединение с базой данных закрыто");
            }
            else
                MessageBox.Show("Соединение с базой данных уже закрыто");
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void MenuItemListConnect_Click(object sender, EventArgs e)
        {
            ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;
            if (settings != null)
            {
                foreach (ConnectionStringSettings cs in settings)
                {
                    MessageBox.Show("name = " + cs.Name);
                    MessageBox.Show("providerName = " + cs.ProviderName);
                    MessageBox.Show("connectionString = " + cs.ConnectionString);
                }
            }
        }
    }
}
