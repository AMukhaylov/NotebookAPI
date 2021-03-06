﻿using NotebookAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NotebookAPI.Controllers
{
    public class ValuesController : ApiController
    {
        ContactContext db = new ContactContext();

        public IEnumerable<Contact> GetBooks()
        {
            return db.Contacts;
        }

        public Contact GetContact(int id)
        {
            Contact contact = db.Contacts.Find(id);
            return contact;
        }

        [HttpPost]
        public void CreateContact([FromBody]Contact contact)
        {
            db.Contacts.Add(contact);
            db.SaveChanges();
        }

        [HttpPut]
        public void EditContact(int id, [FromBody]Contact contact)
        {
            if (id == contact.Id)
            {
                db.Entry(contact).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void DeleteContact(int id)
        {
            Contact contact = db.Contacts.Find(id);
            if (contact != null)
            {
                db.Contacts.Remove(contact);
                db.SaveChanges();
            }
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
