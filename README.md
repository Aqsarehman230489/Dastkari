# 🎨 Dastkari: Artisans Marketplace Website

Dastkari is a collaborative artisan marketplace that connects local Pakistani artists with the world. It allows artisans to sell their handmade products, teach skills, host cultural events, and showcase the vibrant heritage of Pakistan through a modern, user-friendly platform.

---

## 📖 About the Project

> “Dastkari” is a urdu lanuage word means craftsmanship.  
This project is designed to promote local pakistani artisans by providing them a digital space to:

- Sell handmade goods
- Register themselve as an artist
- Collaborate with other artists
- Share stories and techniques
- Host events and exhibitions

🎯 **Goal:** To empower pakistani artisans with modern e-commerce features and connect them with a global audience.

---

## ✨ Features

✅ **Artist Registration & Approval**  
Artists can register through a dedicated form. Admins review and approve applications before public listing to maintain quality.

✅ **Product Listing (Admin & Artists)**  
Admins can add, edit, manage products and artisans profile with images, descriptions, and categories etc.

✅ **Authentication & Authorization with Google**  
Users can log in securely using their Google account through OAuth 2.0 integration, ensuring a seamless and safe experience.

✅ **Event Hosting & Participation with Formspree API Integration**  
Artists can create and host events, while users can view and register for them. Ideal for workshops, exhibitions, and live shows. Form Data Sent Directly to Gmail. 

✅ **Secure Checkout Integration using Stripe**  
Stripe is used to handle payments securely, ensuring encrypted transactions and a smooth checkout process.

✅ **Artist Public Profiles with Edit Option**  
Each artist has a public-facing profile showcasing their products, bio, place, and events. Artists can edit their profile anytime.

✅ **Real-Time Revenue Graphs in admin panel**  
The admin dashboard features a dynamic **Sales Chart** that provides real-time insights into product revenue. This chart is designed to help admins:

- 📈 Monitor daily/weekly/monthly sales trends  
- 🛒 Identify top-performing products  
- 📊 Visualize revenue growth over time  

### 🛠️ Technologies Used

- **Chart.js** (via Blazor integration or JavaScript Interop)  
- Data sourced from the **Orders** and **Products** tables via the backend services  
- Automatically updates with new purchases
✅ **Fully Responsive Design for All Devices**  
Built with mobile-first design principles, the site works beautifully on desktops, tablets, and smartphones.

✅ **Search Functionality**

- 🔍 **Main Website (Users & Artists):**  
  Users and visitors can search for products directly from the homepage using a responsive global search bar. It filters products based on name, category, and artist, making it easy to find items quickly.

- 🔍 **Admin Panel:**  
  Admins have a separate search bar within the dashboard that allows them to search through product records, user accounts, and artist profiles for efficient content management.

✅ **Chatbot Integration (Lyro via Tidio.com) for Real-Time Support**  
An AI-powered chatbot (Lyro) is integrated using Tidio.com to assist users and artisans instantly. It provides answers to common questions, helps navigate the site, and enhances user experience with 24/7 support.

---

## 🛠 Tech Stack

| Layer           | Technology                         |
|----------------|-------------------------------------|
| Frontend        | HTML, CSS, Bootstrap, Blazor        |
| Backend         | .NET (C#), ADO.NET     |
| Database        | SQL Server                          |
| Version Control | Git, GitHub                         |
| Security        | Google OAuth, Stripe, GitHub Secret Scanning |

---
