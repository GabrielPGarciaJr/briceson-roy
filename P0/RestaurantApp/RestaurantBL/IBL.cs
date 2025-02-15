﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using RestaurantModel;

namespace RestaurantBL
{
    public interface IBL
    {
        List<Restaurant> SearchRestaurants(string searchString);

        List<Restaurant> SearchRestaurantsByState(string searchState);

        List<Restaurant> SearchRestaurantByZipCode(int searchZip);

        List<Restaurant> GetAllRestaurants();

        List<Review> GetAllReviews();

        List<Review> GetReviewsById(int id);

        void AddRestaurant(Restaurant restaurantToAdd);

        void AddReview(Review newReview);

        List<User> GetUserAccount(string Username, string Password);

        List<User> GetUserName(string Username);

     

        public List<User> GetUserAccounts(string Username);
    }

    interface IRestaurantSearch
    {
        List<Restaurant> searchAll();
    }
}
