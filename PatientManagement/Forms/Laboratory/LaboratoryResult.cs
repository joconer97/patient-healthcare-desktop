using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientManagement.Forms.Laboratory
{
    public partial class LaboratoryResult : Form
    {
        Classes.LaboratoryRequest laboratoryRequest = null;
        public LaboratoryResult(Classes.LaboratoryRequest laboratoryRequest)
        {
            InitializeComponent();
            this.laboratoryRequest = laboratoryRequest;
        }

        private void LaboratoryResult_Load(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile(laboratoryRequest.result);
        }
    }
}
