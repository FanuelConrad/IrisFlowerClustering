using Microsoft.ML;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

string _dataPath = Path.Combine(Environment.CurrentDirectory, "Data", "iris.data");
string _modelPath = Path.Combine(Environment.CurrentDirectory, "Data", "IrisClusteringModel.zip");

namespace IrisFlowerClustering
{
    class Program
    {
        static void Main(string[] args)
        {
            var mlContext = new MLContext(seed: 0);

            //load data to the dataview
            IDataView dataView = mlContext.Data.LoadFromTextFile<IrisData>(_dataPath, hasHeader: false, separatorChar: ',');
        }
    }
}
