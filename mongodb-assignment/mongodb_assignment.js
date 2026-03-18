// Create database
// use retailDB

// Insert products
db.products.insertMany([
{
name:"Laptop",
category:"Electronics",
price:85000,
stock:50,
brand:"Dell"
},
{
name:"Running Shoes",
category:"Footwear",
price:3500,
stock:120,
brand:"Nike"
},
{
name:"Smartphone",
category:"Electronics",
price:65000,
stock:80,
brand:"Samsung"
}
])

// Insert users
db.users.insertMany([
{
username:"johith",
email:"johith@gmail.com",
passwordHash:"hashed_password_1",
createdAt:new Date()
},
{
username:"rahul",
email:"rahul@gmail.com",
passwordHash:"hashed_password_2",
createdAt:new Date()
}
])

// Insert orders
db.orders.insertMany([
{
userId:"U001",
orderDate:new Date(),
products:[
{
productName:"Laptop",
price:85000,
quantity:1
}
],
totalCost:85000,
paymentStatus:"Paid"
},
{
userId:"U002",
orderDate:new Date(),
products:[
{
productName:"Running Shoes",
price:3500,
quantity:2
}
],
totalCost:7000,
paymentStatus:"Paid"
}
])

// Create indexes
db.products.createIndex({category:1})
db.users.createIndex({email:1},{unique:true})
db.orders.createIndex({userId:1})