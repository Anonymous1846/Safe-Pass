﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafePass
{
    public partial class Vault : UserControl
    {
        private static Vault vaultInstance;
        public static Vault VaultInstance
        {
            //Getting the Instance !
            get
            {
                if (vaultInstance == null)
                    vaultInstance = new Vault();
                return vaultInstance;

            }
        }
        public Vault()
        {
            InitializeComponent();
        }
    }
}
