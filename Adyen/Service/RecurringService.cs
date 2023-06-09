/*
* Adyen Recurring API
*
*
* The version of the OpenAPI document: 68
* Contact: developer-experience@adyen.com
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
using Adyen.Constants;
using Adyen.Model;
using Adyen.Service.Resource;
using Adyen.Model.Recurring;

namespace Adyen.Service
{
    /// <summary>
    /// DefaultService Interface
    /// </summary>
    public interface IRecurringService
    {
        /// <summary>
        /// Create new permits linked to a recurring contract.
        /// </summary>
        /// <param name="createPermitRequest"><see cref="CreatePermitRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="CreatePermitResult"/>.</returns>
        CreatePermitResult CreatePermit(CreatePermitRequest createPermitRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Create new permits linked to a recurring contract.
        /// </summary>
        /// <param name="createPermitRequest"><see cref="CreatePermitRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="CreatePermitResult"/>.</returns>
        Task<CreatePermitResult> CreatePermitAsync(CreatePermitRequest createPermitRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Disable stored payment details
        /// </summary>
        /// <param name="disableRequest"><see cref="DisableRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="DisableResult"/>.</returns>
        DisableResult Disable(DisableRequest disableRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Disable stored payment details
        /// </summary>
        /// <param name="disableRequest"><see cref="DisableRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="DisableResult"/>.</returns>
        Task<DisableResult> DisableAsync(DisableRequest disableRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Disable an existing permit.
        /// </summary>
        /// <param name="disablePermitRequest"><see cref="DisablePermitRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="DisablePermitResult"/>.</returns>
        DisablePermitResult DisablePermit(DisablePermitRequest disablePermitRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Disable an existing permit.
        /// </summary>
        /// <param name="disablePermitRequest"><see cref="DisablePermitRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="DisablePermitResult"/>.</returns>
        Task<DisablePermitResult> DisablePermitAsync(DisablePermitRequest disablePermitRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get stored payment details
        /// </summary>
        /// <param name="recurringDetailsRequest"><see cref="RecurringDetailsRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="RecurringDetailsResult"/>.</returns>
        RecurringDetailsResult ListRecurringDetails(RecurringDetailsRequest recurringDetailsRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get stored payment details
        /// </summary>
        /// <param name="recurringDetailsRequest"><see cref="RecurringDetailsRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="RecurringDetailsResult"/>.</returns>
        Task<RecurringDetailsResult> ListRecurringDetailsAsync(RecurringDetailsRequest recurringDetailsRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Ask issuer to notify the shopper
        /// </summary>
        /// <param name="notifyShopperRequest"><see cref="NotifyShopperRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="NotifyShopperResult"/>.</returns>
        NotifyShopperResult NotifyShopper(NotifyShopperRequest notifyShopperRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Ask issuer to notify the shopper
        /// </summary>
        /// <param name="notifyShopperRequest"><see cref="NotifyShopperRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="NotifyShopperResult"/>.</returns>
        Task<NotifyShopperResult> NotifyShopperAsync(NotifyShopperRequest notifyShopperRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Schedule running the Account Updater
        /// </summary>
        /// <param name="scheduleAccountUpdaterRequest"><see cref="ScheduleAccountUpdaterRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="ScheduleAccountUpdaterResult"/>.</returns>
        ScheduleAccountUpdaterResult ScheduleAccountUpdater(ScheduleAccountUpdaterRequest scheduleAccountUpdaterRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Schedule running the Account Updater
        /// </summary>
        /// <param name="scheduleAccountUpdaterRequest"><see cref="ScheduleAccountUpdaterRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="ScheduleAccountUpdaterResult"/>.</returns>
        Task<ScheduleAccountUpdaterResult> ScheduleAccountUpdaterAsync(ScheduleAccountUpdaterRequest scheduleAccountUpdaterRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
    }
    
    /// <summary>
    /// Represents a collection of functions to interact with the RecurringService API endpoints
    /// </summary>
    public class RecurringService : AbstractService, IRecurringService
    {
        private readonly string _baseUrl;
        
        public RecurringService(Client client) : base(client)
        {
            _baseUrl = CreateBaseUrl("https://pal-test.adyen.com/pal/servlet/Recurring/v68");
        }
        
        public CreatePermitResult CreatePermit(CreatePermitRequest createPermitRequest, RequestOptions requestOptions = default)
        {
            return CreatePermitAsync(createPermitRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<CreatePermitResult> CreatePermitAsync(CreatePermitRequest createPermitRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/createPermit";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<CreatePermitResult>(createPermitRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public DisableResult Disable(DisableRequest disableRequest, RequestOptions requestOptions = default)
        {
            return DisableAsync(disableRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<DisableResult> DisableAsync(DisableRequest disableRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/disable";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<DisableResult>(disableRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public DisablePermitResult DisablePermit(DisablePermitRequest disablePermitRequest, RequestOptions requestOptions = default)
        {
            return DisablePermitAsync(disablePermitRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<DisablePermitResult> DisablePermitAsync(DisablePermitRequest disablePermitRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/disablePermit";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<DisablePermitResult>(disablePermitRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public RecurringDetailsResult ListRecurringDetails(RecurringDetailsRequest recurringDetailsRequest, RequestOptions requestOptions = default)
        {
            return ListRecurringDetailsAsync(recurringDetailsRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<RecurringDetailsResult> ListRecurringDetailsAsync(RecurringDetailsRequest recurringDetailsRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/listRecurringDetails";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<RecurringDetailsResult>(recurringDetailsRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public NotifyShopperResult NotifyShopper(NotifyShopperRequest notifyShopperRequest, RequestOptions requestOptions = default)
        {
            return NotifyShopperAsync(notifyShopperRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<NotifyShopperResult> NotifyShopperAsync(NotifyShopperRequest notifyShopperRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/notifyShopper";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<NotifyShopperResult>(notifyShopperRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public ScheduleAccountUpdaterResult ScheduleAccountUpdater(ScheduleAccountUpdaterRequest scheduleAccountUpdaterRequest, RequestOptions requestOptions = default)
        {
            return ScheduleAccountUpdaterAsync(scheduleAccountUpdaterRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<ScheduleAccountUpdaterResult> ScheduleAccountUpdaterAsync(ScheduleAccountUpdaterRequest scheduleAccountUpdaterRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/scheduleAccountUpdater";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<ScheduleAccountUpdaterResult>(scheduleAccountUpdaterRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
    }
}