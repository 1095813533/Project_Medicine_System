using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using BLL;
using Microsoft.VisualBasic;
namespace Medicine_System
{
    public partial class Doctor_write : Form
    {
        public Doctor_write(Doctor parent)
        {
            InitializeComponent();
            paf = parent;
        }
        
       
    }
}
