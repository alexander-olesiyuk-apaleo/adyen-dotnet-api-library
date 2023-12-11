/*
* Management API
*
*
* The version of the OpenAPI document: 3
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Model;
using Adyen.Model.Management;

namespace Adyen.Service.Management
{
    /// <summary>
    /// AndroidFilesCompanyLevelService Interface
    /// </summary>
    public interface IAndroidFilesCompanyLevelService
    {
        /// <summary>
        /// Get Android app
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="id"><see cref="string"/> - The unique identifier of the app.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="AndroidApp"/>.</returns>
        Model.Management.AndroidApp GetAndroidApp(string companyId, string id, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get Android app
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="id"><see cref="string"/> - The unique identifier of the app.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="AndroidApp"/>.</returns>
        Task<Model.Management.AndroidApp> GetAndroidAppAsync(string companyId, string id, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get a list of Android apps
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="pageNumber"><see cref="int?"/> - The number of the page to fetch.</param>
        /// <param name="pageSize"><see cref="int?"/> - The number of items to have on a page, maximum 100. The default is 20 items on a page.</param>
        /// <param name="packageName"><see cref="string"/> - The package name that uniquely identifies the Android app.</param>
        /// <param name="versionCode"><see cref="int?"/> - The version number of the app.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="AndroidAppsResponse"/>.</returns>
        Model.Management.AndroidAppsResponse ListAndroidApps(string companyId, int? pageNumber = default, int? pageSize = default, string packageName = default, int? versionCode = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get a list of Android apps
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="pageNumber"><see cref="int?"/> - The number of the page to fetch.</param>
        /// <param name="pageSize"><see cref="int?"/> - The number of items to have on a page, maximum 100. The default is 20 items on a page.</param>
        /// <param name="packageName"><see cref="string"/> - The package name that uniquely identifies the Android app.</param>
        /// <param name="versionCode"><see cref="int?"/> - The version number of the app.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="AndroidAppsResponse"/>.</returns>
        Task<Model.Management.AndroidAppsResponse> ListAndroidAppsAsync(string companyId, int? pageNumber = default, int? pageSize = default, string packageName = default, int? versionCode = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get a list of Android certificates
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="pageNumber"><see cref="int?"/> - The number of the page to fetch.</param>
        /// <param name="pageSize"><see cref="int?"/> - The number of items to have on a page, maximum 100. The default is 20 items on a page.</param>
        /// <param name="certificateName"><see cref="string"/> - The name of the certificate.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="AndroidCertificatesResponse"/>.</returns>
        Model.Management.AndroidCertificatesResponse ListAndroidCertificates(string companyId, int? pageNumber = default, int? pageSize = default, string certificateName = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get a list of Android certificates
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="pageNumber"><see cref="int?"/> - The number of the page to fetch.</param>
        /// <param name="pageSize"><see cref="int?"/> - The number of items to have on a page, maximum 100. The default is 20 items on a page.</param>
        /// <param name="certificateName"><see cref="string"/> - The name of the certificate.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="AndroidCertificatesResponse"/>.</returns>
        Task<Model.Management.AndroidCertificatesResponse> ListAndroidCertificatesAsync(string companyId, int? pageNumber = default, int? pageSize = default, string certificateName = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Upload Android App
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        void UploadAndroidApp(string companyId, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Upload Android App
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        Task UploadAndroidAppAsync(string companyId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
    }
    
    /// <summary>
    /// Represents a collection of functions to interact with the AndroidFilesCompanyLevelService API endpoints
    /// </summary>
    public class AndroidFilesCompanyLevelService : AbstractService, IAndroidFilesCompanyLevelService
    {
        private readonly string _baseUrl;
        
        public AndroidFilesCompanyLevelService(Client client) : base(client)
        {
            _baseUrl = CreateBaseUrl("https://management-test.adyen.com/v3");
        }
        
        public Model.Management.AndroidApp GetAndroidApp(string companyId, string id, RequestOptions requestOptions = default)
        {
            return GetAndroidAppAsync(companyId, id, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Management.AndroidApp> GetAndroidAppAsync(string companyId, string id, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/companies/{companyId}/androidApps/{id}";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Management.AndroidApp>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.Management.AndroidAppsResponse ListAndroidApps(string companyId, int? pageNumber = default, int? pageSize = default, string packageName = default, int? versionCode = default, RequestOptions requestOptions = default)
        {
            return ListAndroidAppsAsync(companyId, pageNumber, pageSize, packageName, versionCode, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Management.AndroidAppsResponse> ListAndroidAppsAsync(string companyId, int? pageNumber = default, int? pageSize = default, string packageName = default, int? versionCode = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            // Build the query string
            var queryParams = new Dictionary<string, string>();
            if (pageNumber != null) queryParams.Add("pageNumber", pageNumber.ToString());
            if (pageSize != null) queryParams.Add("pageSize", pageSize.ToString());
            if (packageName != null) queryParams.Add("packageName", packageName);
            if (versionCode != null) queryParams.Add("versionCode", versionCode.ToString());
            var endpoint = _baseUrl + $"/companies/{companyId}/androidApps" + ToQueryString(queryParams);
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Management.AndroidAppsResponse>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.Management.AndroidCertificatesResponse ListAndroidCertificates(string companyId, int? pageNumber = default, int? pageSize = default, string certificateName = default, RequestOptions requestOptions = default)
        {
            return ListAndroidCertificatesAsync(companyId, pageNumber, pageSize, certificateName, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Management.AndroidCertificatesResponse> ListAndroidCertificatesAsync(string companyId, int? pageNumber = default, int? pageSize = default, string certificateName = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            // Build the query string
            var queryParams = new Dictionary<string, string>();
            if (pageNumber != null) queryParams.Add("pageNumber", pageNumber.ToString());
            if (pageSize != null) queryParams.Add("pageSize", pageSize.ToString());
            if (certificateName != null) queryParams.Add("certificateName", certificateName);
            var endpoint = _baseUrl + $"/companies/{companyId}/androidCertificates" + ToQueryString(queryParams);
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Management.AndroidCertificatesResponse>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
        
        public void UploadAndroidApp(string companyId, RequestOptions requestOptions = default)
        {
            UploadAndroidAppAsync(companyId, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task UploadAndroidAppAsync(string companyId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/companies/{companyId}/androidApps";
            var resource = new ServiceResource(this, endpoint);
            await resource.RequestAsync(null, requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
    }
}