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
    public class AdvocatePatchForm : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string name;
        private string lastname;
        private string email;
        private int? payoutThreshold;
        private int? claimedBalance;
        private int? unclaimedBalance;
        private string currencyCode;
        private string avatarUrl;
        private string metadata;
        private bool? canRefer;
        private string token;

        /// <summary>
        /// The advocate's name
        /// </summary>
        [JsonProperty("name")]
        public string Name 
        { 
            get 
            {
                return this.name; 
            } 
            set 
            {
                this.name = value;
                onPropertyChanged("Name");
            }
        }

        /// <summary>
        /// The advocate's last name
        /// </summary>
        [JsonProperty("lastname")]
        public string Lastname 
        { 
            get 
            {
                return this.lastname; 
            } 
            set 
            {
                this.lastname = value;
                onPropertyChanged("Lastname");
            }
        }

        /// <summary>
        /// The advocate's email
        /// </summary>
        [JsonProperty("email")]
        public string Email 
        { 
            get 
            {
                return this.email; 
            } 
            set 
            {
                this.email = value;
                onPropertyChanged("Email");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("payout_threshold")]
        public int? PayoutThreshold 
        { 
            get 
            {
                return this.payoutThreshold; 
            } 
            set 
            {
                this.payoutThreshold = value;
                onPropertyChanged("PayoutThreshold");
            }
        }

        /// <summary>
        /// The total amount of bonuses that the advocate must generate before being able to create a bonus redemption request.
        /// </summary>
        [JsonProperty("claimed_balance")]
        public int? ClaimedBalance 
        { 
            get 
            {
                return this.claimedBalance; 
            } 
            set 
            {
                this.claimedBalance = value;
                onPropertyChanged("ClaimedBalance");
            }
        }

        /// <summary>
        /// The unclaimed balance
        /// </summary>
        [JsonProperty("unclaimed_balance")]
        public int? UnclaimedBalance 
        { 
            get 
            {
                return this.unclaimedBalance; 
            } 
            set 
            {
                this.unclaimedBalance = value;
                onPropertyChanged("UnclaimedBalance");
            }
        }

        /// <summary>
        /// The currency code
        /// </summary>
        [JsonProperty("currency_code")]
        public string CurrencyCode 
        { 
            get 
            {
                return this.currencyCode; 
            } 
            set 
            {
                this.currencyCode = value;
                onPropertyChanged("CurrencyCode");
            }
        }

        /// <summary>
        /// The advocate's avatar URL
        /// </summary>
        [JsonProperty("avatar_url")]
        public string AvatarUrl 
        { 
            get 
            {
                return this.avatarUrl; 
            } 
            set 
            {
                this.avatarUrl = value;
                onPropertyChanged("AvatarUrl");
            }
        }

        /// <summary>
        /// Useful to store extra information about the advocate. e.g, the phone number, address, etc.
        /// </summary>
        [JsonProperty("metadata")]
        public string Metadata 
        { 
            get 
            {
                return this.metadata; 
            } 
            set 
            {
                this.metadata = value;
                onPropertyChanged("Metadata");
            }
        }

        /// <summary>
        /// Whether or not the advocate is allowed to refer services/products (Useful when using the Full Widget template).
        /// </summary>
        [JsonProperty("can_refer")]
        public bool? CanRefer 
        { 
            get 
            {
                return this.canRefer; 
            } 
            set 
            {
                this.canRefer = value;
                onPropertyChanged("CanRefer");
            }
        }

        /// <summary>
        /// The advocate's token
        /// </summary>
        [JsonProperty("token")]
        public string Token 
        { 
            get 
            {
                return this.token; 
            } 
            set 
            {
                this.token = value;
                onPropertyChanged("Token");
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