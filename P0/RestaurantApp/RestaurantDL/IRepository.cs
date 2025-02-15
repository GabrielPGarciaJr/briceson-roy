﻿using Models;
using RestaurantModel;

namespace RestaurantDL
{
    public interface IRepository
    {
        List<Restaurant> GetAllRestaurants();

        List<Review> GetAllReviews();

        List<User> GetAllUsers();

        User GetUserByName(string username);

        Restaurant AddRestaurant(Restaurant restaurantToAdd);

        void AddReview(int restaurantId, Review reviewToAdd);

        User AddUser(User userToAdd);

        List<Restaurant> SearchRestaurants(string searchTerm);

        Restaurant GetRestaurantById(int restaurantId);

        bool IsDuplicate(Restaurant restaurant);
        void AddReview(Review newReview);
    }
}