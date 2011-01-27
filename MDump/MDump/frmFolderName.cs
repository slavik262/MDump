﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MDump
{
    public partial class frmFolderName : Form
    {
        /// <summary>
        /// Gets the folder name entered in the dialog
        /// </summary>
        public string FolderName { get { return txtName.Text; } }

        private readonly Color defaultTextBackColor;

        public frmFolderName()
        {
            InitializeComponent();
            defaultTextBackColor = txtName.BackColor;
            lblStatus.ForeColor = Colors.InvalidColor;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Length == 0)
            {
                lblStatus.Visible = false;
                txtName.BackColor = defaultTextBackColor;
                btnOk.Enabled = false;
            }
            else if (!PathManager.IsValidDirName(txtName.Text))
            {
                lblStatus.Visible = true;
                txtName.BackColor = Colors.InvalidBGColor;
                btnOk.Enabled = false;
            }
            else
            {
                lblStatus.Visible = false;
                txtName.BackColor = Colors.ValidBGColor;
                btnOk.Enabled = true;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }
    }
}