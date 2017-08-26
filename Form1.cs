using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.MachineLearning.DecisionTrees.Rules;
using Accord.Math;
using Accord.Math.Optimization.Losses;
using Accord.Statistics.Filters;

namespace RuleInference
{
    public partial class Form1 : Form
    {
        DataSet1.TradeDataDataTable tradeTable = new DataSet1.TradeDataDataTable();

        public Form1()
        {
            InitializeComponent();

            textBoxExpression.Text = "MarketPrice < 50 OR (Notional < 20 AND Strike > 10)";
        }

        private void ComputeInference()
        {
            var codebook = new Codification();
       
            codebook.Learn(tradeTable);
          
            DataTable symbols = codebook.Apply(tradeTable);
         
            string[] inputNames = new[] { "Strike", "MarketPrice", "Notional" };
            double[][] inputs = tradeTable.ToJagged(inputNames);
            int[] outputs = tradeTable.ToArray<int>("Result");

           
            var teacher = new C45Learning()
            {
                Attributes = DecisionVariable.FromCodebook(codebook, inputNames)
            };

          
            DecisionTree tree = teacher.Learn(inputs, outputs);      
            int[] predicted = tree.Decide(inputs);           
            double error = new ZeroOneLoss(outputs).Loss(predicted);
            DecisionSet rules = tree.ToRules();

            var str = rules.ToString();       
            textBoxInferredRules.Text = str;
        }

        private void GenerateData_Click(object sender, EventArgs e)
        {

            tradeTable.Clear();

            var random = new Random();
      
            var tradeId = 0;

            tradeTable.ResultColumn.Expression = textBoxExpression.Text;

            for(int i=0;i < 100*10;i++)
            {
                var newRow = tradeTable.NewTradeDataRow();
                newRow.TradeDate = DateTime.Today;
                newRow.MarketPrice = random.Next(100);
                newRow.Strike = random.Next(100);
                newRow.Notional = random.Next(100);
                newRow.TradeID = tradeId++.ToString();
                newRow.Symbol = "GOOG.N";   
                tradeTable.AddTradeDataRow(newRow);
            }

            tradeDataBindingSource1.DataSource = tradeTable;

            ComputeInference();
           
        }
    }
}
