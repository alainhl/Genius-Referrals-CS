/*
 * GeniusReferrals.UWP
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ) on 02/17/2017
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using GeniusReferrals.UWP;
using GeniusReferrals.UWP.Utilities;
using GeniusReferrals.UWP.Http.Request;
using GeniusReferrals.UWP.Http.Response;
using GeniusReferrals.UWP.Http.Client;
using GeniusReferrals.UWP.Exceptions;
using GeniusReferrals.UWP.Models;

namespace GeniusReferrals.UWP.Controllers
{
    public partial class ReferralsController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static ReferralsController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static ReferralsController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new ReferralsController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Get a referral origin by a given slug.
        /// </summary>
        /// <param name="referralOriginSlug">Required parameter: The referral origin identifier</param>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic GetReferralOrigin(string referralOriginSlug)
        {
            Task<dynamic> t = GetReferralOriginAsync(referralOriginSlug);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get a referral origin by a given slug.
        /// </summary>
        /// <param name="referralOriginSlug">Required parameter: The referral origin identifier</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetReferralOriginAsync(string referralOriginSlug)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/utilities/referral-origins/{referral_origin_slug}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "referral_origin_slug", referralOriginSlug }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };
            _headers.Add("Content-Type", Configuration.ContentType);
            _headers.Add("X-Auth-Token", Configuration.XAuthToken);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Get referral origins. This is needed when creating (POST) a new referral, as referral_origin_slug refers to one of this origins.
        /// </summary>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic GetReferralOrigins()
        {
            Task<dynamic> t = GetReferralOriginsAsync();
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get referral origins. This is needed when creating (POST) a new referral, as referral_origin_slug refers to one of this origins.
        /// </summary>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetReferralOriginsAsync()
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/utilities/referral-origins");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };
            _headers.Add("Content-Type", Configuration.ContentType);
            _headers.Add("X-Auth-Token", Configuration.XAuthToken);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Get a referral by a given id.
        /// </summary>
        /// <param name="accountSlug">Required parameter: The account identifier</param>
        /// <param name="advocateToken">Required parameter: The advocate's token</param>
        /// <param name="referralId">Required parameter: The referral id</param>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic GetReferral(string accountSlug, string advocateToken, string referralId)
        {
            Task<dynamic> t = GetReferralAsync(accountSlug, advocateToken, referralId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get a referral by a given id.
        /// </summary>
        /// <param name="accountSlug">Required parameter: The account identifier</param>
        /// <param name="advocateToken">Required parameter: The advocate's token</param>
        /// <param name="referralId">Required parameter: The referral id</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetReferralAsync(string accountSlug, string advocateToken, string referralId)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/accounts/{account_slug}/advocates/{advocate_token}/referrals/{referral_id}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "account_slug", accountSlug },
                { "advocate_token", advocateToken },
                { "referral_id", referralId }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };
            _headers.Add("Content-Type", Configuration.ContentType);
            _headers.Add("X-Auth-Token", Configuration.XAuthToken);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Delete a referral.
        /// </summary>
        /// <param name="accountSlug">Required parameter: The account identifier</param>
        /// <param name="advocateToken">Required parameter: The advocate's token</param>
        /// <param name="referralId">Required parameter: The referral identifier</param>
        /// <return>Returns the void response from the API call</return>
        public void DeleteReferral(string accountSlug, string advocateToken, string referralId)
        {
            Task t = DeleteReferralAsync(accountSlug, advocateToken, referralId);
            APIHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Delete a referral.
        /// </summary>
        /// <param name="accountSlug">Required parameter: The account identifier</param>
        /// <param name="advocateToken">Required parameter: The advocate's token</param>
        /// <param name="referralId">Required parameter: The referral identifier</param>
        /// <return>Returns the void response from the API call</return>
        public async Task DeleteReferralAsync(string accountSlug, string advocateToken, string referralId)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/accounts/{account_slug}/advocates/{advocate_token}/referrals/{referral_id}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "account_slug", accountSlug },
                { "advocate_token", advocateToken },
                { "referral_id", referralId }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
            };
            _headers.Add("Content-Type", Configuration.ContentType);
            _headers.Add("X-Auth-Token", Configuration.XAuthToken);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Delete(_queryUrl, _headers, null);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

        }

        /// <summary>
        /// Create a new referral.
        /// </summary>
        /// <param name="accountSlug">Required parameter: The account identifier</param>
        /// <param name="advocateToken">Required parameter: The advocate's token</param>
        /// <param name="referralForm">Required parameter: The body of the request</param>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic PostReferrals(string accountSlug, string advocateToken, ReferralForm referralForm)
        {
            Task<dynamic> t = PostReferralsAsync(accountSlug, advocateToken, referralForm);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Create a new referral.
        /// </summary>
        /// <param name="accountSlug">Required parameter: The account identifier</param>
        /// <param name="advocateToken">Required parameter: The advocate's token</param>
        /// <param name="referralForm">Required parameter: The body of the request</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> PostReferralsAsync(string accountSlug, string advocateToken, ReferralForm referralForm)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/accounts/{account_slug}/advocates/{advocate_token}/referrals");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "account_slug", accountSlug },
                { "advocate_token", advocateToken }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" }
            };
            _headers.Add("Content-Type", Configuration.ContentType);
            _headers.Add("X-Auth-Token", Configuration.XAuthToken);

            //append body params
            var _body = APIHelper.JsonSerialize(referralForm);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PostBody(_queryUrl, _headers, _body);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Update a referral.
        /// </summary>
        /// <param name="accountSlug">Required parameter: The account identifier</param>
        /// <param name="advocateToken">Required parameter: The advocate's token</param>
        /// <param name="referralId">Required parameter: The referral id</param>
        /// <param name="referralForm">Required parameter: The body of the request</param>
        /// <return>Returns the void response from the API call</return>
        public void PutReferral(
                string accountSlug,
                string advocateToken,
                string referralId,
                ReferralForm referralForm)
        {
            Task t = PutReferralAsync(accountSlug, advocateToken, referralId, referralForm);
            APIHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Update a referral.
        /// </summary>
        /// <param name="accountSlug">Required parameter: The account identifier</param>
        /// <param name="advocateToken">Required parameter: The advocate's token</param>
        /// <param name="referralId">Required parameter: The referral id</param>
        /// <param name="referralForm">Required parameter: The body of the request</param>
        /// <return>Returns the void response from the API call</return>
        public async Task PutReferralAsync(
                string accountSlug,
                string advocateToken,
                string referralId,
                ReferralForm referralForm)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/accounts/{account_slug}/advocates/{advocate_token}/referrals/{referral_id}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "account_slug", accountSlug },
                { "advocate_token", advocateToken },
                { "referral_id", referralId }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "content-type", "application/json; charset=utf-8" }
            };
            _headers.Add("Content-Type", Configuration.ContentType);
            _headers.Add("X-Auth-Token", Configuration.XAuthToken);

            //append body params
            var _body = APIHelper.JsonSerialize(referralForm);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PutBody(_queryUrl, _headers, _body);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

        }

        /// <summary>
        /// Get the list of referrals for a given advocate.
        /// </summary>
        /// <param name="accountSlug">Required parameter: The account identifier</param>
        /// <param name="advocateToken">Required parameter: The advocate's token</param>
        /// <param name="page">Optional parameter: Page number, e.g. 1 would start at the first result, and 10 would start at the tenth result.</param>
        /// <param name="limit">Optional parameter: Maximum number of results to return in the response. Default (10), threshold (100)</param>
        /// <param name="filter">Optional parameter: Allowed fields: url, referral_origin_slug, created. Use the following delimiters to build your filters params. Use the following delimiters to build your filters params. The vertical bar ('\|') to separate individual filter phrases and a double colon ('::') to separate the names and values. The delimiter of the double colon (':') separates the property name from the comparison value, enabling the comparison value to contain spaces. Example: www.example.com/users?filter='name::todd\|city::denver\|title::grand poobah'</param>
        /// <param name="sort">Optional parameter: Allowed fields: created. Use sort query-string parameter that contains a delimited set of property names. For each property name, sort in ascending order, and for each property prefixed with a dash ('-') sort in descending order. Separate each property name with a vertical bar ('\|'), which is consistent with the separation of the name\|value pairs in filtering, above. For example, if we want to retrieve users in order of their last name (ascending), first name (ascending) and hire date (descending), the request might look like this www.example.com/users?sort='last_name\|first_name\|-hire_date'</param>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic GetReferrals(
                string accountSlug,
                string advocateToken,
                int? page = null,
                int? limit = null,
                string filter = null,
                string sort = null)
        {
            Task<dynamic> t = GetReferralsAsync(accountSlug, advocateToken, page, limit, filter, sort);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get the list of referrals for a given advocate.
        /// </summary>
        /// <param name="accountSlug">Required parameter: The account identifier</param>
        /// <param name="advocateToken">Required parameter: The advocate's token</param>
        /// <param name="page">Optional parameter: Page number, e.g. 1 would start at the first result, and 10 would start at the tenth result.</param>
        /// <param name="limit">Optional parameter: Maximum number of results to return in the response. Default (10), threshold (100)</param>
        /// <param name="filter">Optional parameter: Allowed fields: url, referral_origin_slug, created. Use the following delimiters to build your filters params. Use the following delimiters to build your filters params. The vertical bar ('\|') to separate individual filter phrases and a double colon ('::') to separate the names and values. The delimiter of the double colon (':') separates the property name from the comparison value, enabling the comparison value to contain spaces. Example: www.example.com/users?filter='name::todd\|city::denver\|title::grand poobah'</param>
        /// <param name="sort">Optional parameter: Allowed fields: created. Use sort query-string parameter that contains a delimited set of property names. For each property name, sort in ascending order, and for each property prefixed with a dash ('-') sort in descending order. Separate each property name with a vertical bar ('\|'), which is consistent with the separation of the name\|value pairs in filtering, above. For example, if we want to retrieve users in order of their last name (ascending), first name (ascending) and hire date (descending), the request might look like this www.example.com/users?sort='last_name\|first_name\|-hire_date'</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetReferralsAsync(
                string accountSlug,
                string advocateToken,
                int? page = null,
                int? limit = null,
                string filter = null,
                string sort = null)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/accounts/{account_slug}/advocates/{advocate_token}/referrals");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "account_slug", accountSlug },
                { "advocate_token", advocateToken }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "page", page },
                { "limit", limit },
                { "filter", filter },
                { "sort", sort }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };
            _headers.Add("Content-Type", Configuration.ContentType);
            _headers.Add("X-Auth-Token", Configuration.XAuthToken);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 