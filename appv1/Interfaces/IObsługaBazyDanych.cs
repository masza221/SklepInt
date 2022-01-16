﻿using System.Collections.Generic;
using appv1.DAL.Contexts;
using appv1.DAL.Models;
using appv1.Models;

namespace appv1.Interfaces
{
    public interface IObslugaBazyDanych
    {
        public SklepContext Context { get; set; }


        public void DodajProduct(Products product);
        public List<Login> GetUsers();

        public Login User(string username, string password);

        public List<Products> GetKategory( string name);
        public int SprawdzIlosc(int id);

        public List<Products> GetProducts();
        public void UsunProduct(int id);
        public void Zarejestruj(Login user);
        Products Find(int id);
        void DodajZamowienie(Zamowienie zamowienie, List<Koszyk> koszyk);
      
    }
}