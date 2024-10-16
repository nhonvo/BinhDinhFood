- use cache for profile


# Suggest api

## 1. **Authentication & Authorization**

- **POST** `/auth/register`
  Registers a new user (customer or admin).
- **POST** `/auth/login`
  Logs in the user and returns a JWT token.
- **POST** `/auth/refresh-token`
  Refreshes the JWT token.
- **POST** `/auth/logout`
  Logs out the user and invalidates the token.

## 2. **User Management**

- **GET** `/users/{id}`
  Get user details by ID.
- **PUT** `/users/{id}`
  Update user details (address, contact, etc.).
- **DELETE** `/users/{id}`
  Delete a user account.
- **GET** `/users/me`
  Get details of the currently authenticated user.
- **GET** `/users/orders`
  Get the list of orders made by the current user.

## 3. **Product Management**

- **GET** `/products`
  Get a list of products with filtering, pagination, and sorting.
- **GET** `/products/{id}`
  Get detailed information for a specific product by ID.
- **POST** `/products` (Admin Only)
  Add a new product to the catalog.
- **PUT** `/products/{id}` (Admin Only)
  Update details of a specific product.
- **DELETE** `/products/{id}` (Admin Only)
  Delete a product from the catalog.
- **GET** `/products/categories`
  Get a list of product categories.
- **GET** `/products/category/{categoryId}`
  Get a list of products filtered by category.
- **POST** `/products/review/{productId}`
  Add a review for a product.
- **GET** `/products/review/{productId}`
  Get reviews for a product.
- **POST** `/products/rating/{productId}`
  Add a rating for a product.

## 4. **Category & blog & banner Management**

- **GET** `/categories`
  Get a list of all categories.
- **GET** `/categories/{id}`
  Get details of a specific category.
- **POST** `/categories` (Admin Only)
  Create a new category.
- **PUT** `/categories/{id}` (Admin Only)
  Update an existing category.
- **DELETE** `/categories/{id}` (Admin Only)
  Delete a category.

## 5. **Cart & Wishlist & favorite**

- **GET** `/cart`
  Get the contents of the user's shopping cart.
- **POST** `/cart`
  Add an item to the cart.
- **PUT** `/cart/{itemId}`
  Update quantity or other details of a cart item.
- **DELETE** `/cart/{itemId}`
  Remove an item from the cart.
- **POST** `/cart/checkout`
  Proceed to checkout.
- **GET** `/wishlist`
  Get the user's wishlist.
- **POST** `/wishlist`
  Add an item to the wishlist.
- **DELETE** `/wishlist/{itemId}`
  Remove an item from the wishlist.

## 6. **Order Management**

- **POST** `/orders`
  Place a new order.
- **GET** `/orders/{id}`
  Get details of a specific order.
- **GET** `/orders/user/{userId}`
  Get the list of orders for a specific user.
- **PUT** `/orders/{id}/cancel`
  Cancel an order.
- **GET** `/orders/status/{orderId}`
  Get the current status of an order (e.g., processing, shipped).
- **POST** `/orders/track/{orderId}`
  Track the shipping status of an order.

## 7. **Payment Management**

- **POST** `/payments`
  Process a payment for an order.
- **GET** `/payments/status/{orderId}`
  Get the status of the payment for a specific order.
- **POST** `/payments/refund/{orderId}`
  Process a refund for an order.
- **GET** `/payments/history`
  Get the payment history of a user.

## 8. **Shipping & Address Management**

- **GET** `/shipping/methods`
  Get available shipping methods.
- **POST** `/shipping/calculate`
  Calculate shipping costs for an order.
- **POST** `/shipping/address`
  Add a new shipping address for the user.
- **PUT** `/shipping/address/{id}`
  Update an existing shipping address.
- **DELETE** `/shipping/address/{id}`
  Delete a shipping address.

## 9. **Admin Operations**

- **GET** `/admin/dashboard`
  Get admin dashboard statistics (orders, revenue, users, etc.).
- **GET** `/admin/orders`
  Get a list of all orders for management.
- **GET** `/admin/products`
  Get a list of products with the ability to manage them.
- **GET** `/admin/users`
  Get a list of all users.
- **GET** `/admin/reports`
  Generate sales reports, order reports, etc.

## 10. **Discount & Coupon Management**

- **GET** `/coupons`
  Get a list of active coupons/discounts.
- **POST** `/coupons` (Admin Only)
  Create a new coupon.
- **PUT** `/coupons/{id}` (Admin Only)
  Update an existing coupon.
- **DELETE** `/coupons/{id}` (Admin Only)
  Delete a coupon.
- **POST** `/coupons/apply`
  Apply a coupon to a cart/order.

## 11. **Product Recommendation & Search**

- **GET** `/products/recommendations`
  Get personalized product recommendations for the user.
- **GET** `/products/search`
  Search products by keyword, category, or filters (e.g., price, rating).
- **GET** `/products/related/{productId}`
  Get related or similar products for a specific product.

## 12. **Notification Management**

- **GET** `/notifications`
  Get a list of user notifications.
- **POST** `/notifications`
  Send a new notification (Admin Only).
- **DELETE** `/notifications/{id}`
  Delete a notification.

## 13. **Analytics & Tracking**

- **GET** `/analytics/product-views/{productId}`
  Get view counts for a product.
- **GET** `/analytics/sales`
  Get sales data for reporting and analysis.
- **GET** `/analytics/top-products`
  Get the list of top-selling products.
- **GET** `/analytics/customer-insights`
  Get customer purchase patterns and trends.
