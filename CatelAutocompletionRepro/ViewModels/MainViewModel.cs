using Catel.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatelAutocompletionRepro.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            FilterSource = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("Planet1", "Mercury"),
                new KeyValuePair<string, string>("Planet2", "Venus"),
                new KeyValuePair<string, string>("Planet3", "Earth"),
                new KeyValuePair<string, string>("Planet4", "Mars"),
                new KeyValuePair<string, string>("Planet5", "Jupiter"),
                new KeyValuePair<string, string>("Planet6", "Saturn"),
                new KeyValuePair<string, string>("Planet7", "Uranus"),
                new KeyValuePair<string, string>("Planet8", "Neptune")
            };

            PropertyName = "Value";
        }

        public string PropertyName { get; set; }


        /// <summary>
        /// This ItemSource binding will cause Exception here:
        /// AutoCompletionService.cs:
        ///                         propertyValues.AddRange(from x in source.Cast<object>()
        ///                                                     select GetPropertyValue(x, property));
        /// </summary>
        public List<KeyValuePair<string, string>> FilterSource { get; set; }
    }
}
