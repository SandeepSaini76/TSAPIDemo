﻿/*
 Copyright 2015 TSAPI.NET project

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tsapi;

namespace TSAPIDemo
{
    public partial class cstaSetForwardingPopupForm : Form
    {
        public cstaSetForwardingPopupForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.deviceId = this.deviceIdTextBox.Text;
            this.disableForwarding = this.disableForwardCheckBox.Checked;
            this.DialogResult = DialogResult.OK;
        }

        private void deviceIdTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) okButton_Click(sender, e);
        }

        internal mainForm _parent;
        internal Csta.DeviceID_t deviceId;
        internal bool disableForwarding = false;

        private void disableForwardCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.disableForwardCheckBox.Checked)
                this.deviceIdTextBox.Enabled = false;
            else
                this.deviceIdTextBox.Enabled = true;
        }
    }
}