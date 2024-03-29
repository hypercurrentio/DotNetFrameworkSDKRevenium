/* 
 * Revenium Metering API
 *
 * Revenium Metering API
 *
 * OpenAPI spec version: 1.14.0-SNAPSHOT
 * Contact: info@revenium.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.io.revenium;
using IO.Swagger.io.revenium;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing EventsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class EventsApiTests
    {
        private EventsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new EventsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of EventsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' EventsApi
            //Assert.IsInstanceOfType(typeof(EventsApi), instance, "instance is a EventsApi");
        }

        /// <summary>
        /// Test SaveEvent
        /// </summary>
        [Test]
        public void SaveEventTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ApiEventDTO body = null;
            //instance.SaveEvent(body);
            
        }
    }

}
