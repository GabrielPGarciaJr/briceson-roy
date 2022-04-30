﻿using Models;
using RestaurantModel;

namespace RestaurantDL
{
    public interface IRepository
    {
        List<Restaurant> GetAllRestaurants();

        List<Review> GetAllReviews();

        List<Review> GetSomeReviews(int restaurantId);

        Restaurant AddRestaurant(Restaurant restaurantToAdd);

        void AddReview(int restaurantId, Review reviewToAdd);

        User AddUser(User userToAdd);

        void UpdateAvgRating(int restaurantId, decimal rating);

        List<Restaurant> SearchRestaurants(string searchTerm);

        bool IsDuplicate(Restaurant restaurant);
        void AddReview(Review newReview);
    }
}