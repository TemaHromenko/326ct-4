using System.Data;
using System.Windows.Forms;
using Lab_2.Lab_2DataSetTableAdapters;

namespace Lab_2
{
    internal static class StaticData
    {
        public static Lab_2DataSet lab_2DataSet;

        public static BindingSource iNDUSTRYBindingSource;
        public static INDUSTRYTableAdapter iNDUSTRYTableAdapter;

        public static BindingSource hOLDINGSBindingSource;
        public static HOLDINGSTableAdapter hOLDINGSTableAdapter;

        public static BindingSource mASTERBindingSource;
        public static MASTERTableAdapter mASTERTableAdapter;

        public static void Init()
        {
            lab_2DataSet = new Lab_2DataSet();

            iNDUSTRYBindingSource = new BindingSource();
            iNDUSTRYTableAdapter = new INDUSTRYTableAdapter();

            hOLDINGSBindingSource = new BindingSource();
            hOLDINGSTableAdapter = new HOLDINGSTableAdapter();

            mASTERBindingSource = new BindingSource();
            mASTERTableAdapter = new MASTERTableAdapter();

            ((System.ComponentModel.ISupportInitialize)(lab_2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(iNDUSTRYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(hOLDINGSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(mASTERBindingSource)).BeginInit();

            lab_2DataSet.DataSetName = "Lab_2DataSet";
            lab_2DataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;

            iNDUSTRYBindingSource.DataMember = "INDUSTRY";
            iNDUSTRYBindingSource.DataSource = lab_2DataSet;
            iNDUSTRYTableAdapter.ClearBeforeFill = true;

            hOLDINGSBindingSource.DataMember = "HOLDINGS";
            hOLDINGSBindingSource.DataSource = lab_2DataSet;
            hOLDINGSTableAdapter.ClearBeforeFill = true;

            mASTERBindingSource.DataMember = "MASTER";
            mASTERBindingSource.DataSource = lab_2DataSet;
            mASTERTableAdapter.ClearBeforeFill = true;

            ((System.ComponentModel.ISupportInitialize)(lab_2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(iNDUSTRYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(hOLDINGSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(mASTERBindingSource)).EndInit();
        }
    }
}
