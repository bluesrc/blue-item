﻿#region Licence
/**
* Copyright © 2014-2019 OTTools <https://github.com/ottools/ItemEditor/>
*
* This program is free software; you can redistribute it and/or modify
* it under the terms of the GNU General Public License as published by
* the Free Software Foundation; either version 2 of the License, or
* (at your option) any later version.
*
* This program is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
* GNU General Public License for more details.
*
* You should have received a copy of the GNU General Public License along
* with this program; if not, write to the Free Software Foundation, Inc.,
* 51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
*/
#endregion

#region Using Statements
using System.Reflection;
using System.Windows.Forms;
#endregion

namespace BlueItem.Dialogs
{
    public partial class AboutForm : Form
    {
        #region Constructor

        public AboutForm()
        {
            this.InitializeComponent();
            this.InitializeGraphics();
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Attaches the image to the imagebox
        /// </summary>
        private void InitializeGraphics()
        {
            this.pictureBox.Image = BlueItem.Properties.Resources.about_background;
            this.versionLabel.Text = MainForm.ApplicationVersion;
        }

        #endregion

        #region Event Handlers

        private void LinkLabelClickedHandler(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel label = (LinkLabel)sender;
            System.Diagnostics.Process.Start(label.Text);
        }

        #endregion
    }
}
