using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppExam.models;

namespace WindowsFormsAppExam
{
    static internal class ConstData
    {
        public static readonly string HOST = "localhost";
        public static readonly string USER = "postgres";
        public static readonly string DBNAME = "WindowsFormsAppExam";
        public static readonly string PASSWORD = "postgres";
        public static readonly string PORT = "5432";
        public static readonly string CONNSTRING = String.Format(
                                            "Server={0};Username={1};Database={2};Port={3};Password={4};SSLMode=Prefer",
                                            HOST, USER, DBNAME, PORT, PASSWORD);
        public static User CURRENT_USER = null;
        public static RepairRequest TRACK_REQUEST = null;
    }
}
