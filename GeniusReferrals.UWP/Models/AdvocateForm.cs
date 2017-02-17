/*
 * GeniusReferrals.UWP
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ) on 02/17/2017
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using GeniusReferrals.UWP;
using GeniusReferrals.UWP.Utilities;

namespace GeniusReferrals.UWP.Models
{
    public class AdvocateForm : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private Advocate advocate;

        /// <summary>
        /// The advocate's wrapper
        /// </summary>
        [JsonProperty("advocate")]
        public Advocate Advocate 
        { 
            get 
            {
                return this.advocate; 
            } 
            set 
            {
                this.advocate = value;
                onPropertyChanged("Advocate");
            }
        }

        /// <summary>
        /// Property changed event for observer pattern
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises event when a property is changed
        /// </summary>
        /// <param name="propertyName">Name of the changed property</param>
        protected void onPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
} 