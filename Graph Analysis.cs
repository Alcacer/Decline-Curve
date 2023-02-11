using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decline_Curve_Analysis
{
    
        // TODO - Take the results from the data entry form
        //TODO - Plot the graph with the data
        //TODO - With the data given, calculate and predict future data
        //TODO - Save the results to a csv file if the save button is pressed or display the results in a table before the option to save.
    
    public class GraphAnalysis
    {
        public string Time { get; set; }
        public string Rate { get; set; }
        public object this[string propertyName]
        {
            get { return this.GetType().GetProperty(propertyName).GetValue(this, null); }
            set { this.GetType().GetProperty(propertyName).SetValue(this, value, null); }
        }
    }
}
