﻿using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace NganHang
{
    public partial class XR_LietKeKhachHang1 : DevExpress.XtraReports.UI.XtraReport
    {
        public XR_LietKeKhachHang1()
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Fill();
        }

    }
}
