﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.DTOs;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class CustomersController : ApiController
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
                    }

        // GET /api/customers
        public IEnumerable<CustomerDTOs> GetCustomers()
        {
            return _context.Customers.ToList().Select(Mapper.Map<Customer, CustomerDTOs>);
        }

        //Get /api/customers/1
        public IHttpActionResult  GetCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            
            if(customer == null)
            {
                return NotFound();
            }
            return  Ok(Mapper.Map<Customer, CustomerDTOs>(customer));
           
        }

        //Post /api/customers
        //[HttpPost]
        public IHttpActionResult CreateCustomer(CustomerDTOs  customerDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();

            }

            var customer = Mapper.Map<CustomerDTOs, Customer>(customerDTO);
            _context.Customers.Add(customer);
            _context.SaveChanges();

            customerDTO.Id = customer.Id;

                return Created(new Uri(Request.RequestUri + "/" + customer.Id), customerDTO);
            }

        //PUT /api/customers/1
        [HttpPut]
        public  void UpdateCustomer(int id, CustomerDTOs customerDTO)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            }

            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if(customerInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            Mapper.Map(customerDTO, customerInDb);
            

            _context.SaveChanges();

        }

        //DELETE /api/customers/1
        public void DeleteCustomer(int id)
        {
            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            _context.Customers.Remove(customerInDb);
            _context.SaveChanges();


        }
       }
    }


