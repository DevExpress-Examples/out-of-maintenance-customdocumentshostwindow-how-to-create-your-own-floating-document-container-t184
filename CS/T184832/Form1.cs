using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Docking2010;

namespace T184832 {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        public Form1() {
            InitializeComponent();
            documentManager1.View.CustomDocumentsHostWindow += View_CustomDocumentsHostWindow;
            documentManager1.View.FloatingDocumentContainer = DevExpress.XtraBars.Docking2010.Views.FloatingDocumentContainer.DocumentsHost;
        }

        void tabbedView1_QueryControl(object sender, QueryControlEventArgs e) {
            e.Control = new Control();
        }

        void View_CustomDocumentsHostWindow(object sender, CustomDocumentsHostWindowEventArgs e) {
            e.Constructor = new DevExpress.XtraBars.Docking2010.DocumentsHostWindowConstructor(CreateCustomHost);
        }

        private CustomDocHost CreateCustomHost() {
            return new CustomDocHost();
        }
    }

    public class CustomDocHost : Form, IDocumentsHostWindow {
        DocumentManager floatDocHost;

        public CustomDocHost() {
            floatDocHost = new DocumentManager();
            floatDocHost.ContainerControl = this;
            floatDocHost.View.DocumentClosing += View_DocumentClosing;
            floatDocHost.View.FloatingDocumentContainer = DevExpress.XtraBars.Docking2010.Views.FloatingDocumentContainer.DocumentsHost;
        }

        void View_DocumentClosing(object sender, DevExpress.XtraBars.Docking2010.Views.DocumentCancelEventArgs e) {
            //do something 
        }

        public bool DestroyOnRemovingChildren {
            get { return true; }
        }

        public DocumentManager DocumentManager {
            get { return floatDocHost; }
        }

        protected override void Dispose(bool disposing) {
            if (disposing)
                floatDocHost.Dispose();
            base.Dispose(disposing);
        }
    }
}
