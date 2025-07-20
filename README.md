# Blake Sample Blog Template – Tailwind

A clean and minimal starter template for building Markdown-powered blogs with the [Blake](https://github.com/matt-goldman/blake) static site generator.
Styled with [Tailwind CSS](https://tailwindcss.com/) and ready to deploy.

---

## ✨ Features

* ✍️ Write posts in plain Markdown
* 🎨 Fully responsive design with Tailwind CSS v4
* ⚡ Build output ready for static hosting
* 🚀 Includes a GitHub Actions workflow for automatic deployment

---

## 🚧 Prerequisites

Make sure you have the following installed:

* [.NET 9 SDK](https://dotnet.microsoft.com/download/)
* [Node.js](https://nodejs.org/) (for Tailwind build)
* The Blake CLI:

```bash
dotnet tool install -g Blake.CLI
```

---

## 🚀 Getting Started

1. **Clone the repository:**

   ```bash
   git clone https://github.com/matt-goldman/blake-sample-blog.git
   cd blake-sample-blog
   ```

2. **Install dependencies:**

   ```bash
   npm install
   ```

3. **Build the site:**

   ```bash
   blake bake
   ```

4. **Start the development server:**

   ```bash
   dotnet run
   ```

5. **Or do both in one step:**

   ```bash
   blake serve
   ```

---

## 🛠 Customisation

* **Posts:**
  Add Markdown files to the `posts/` folder. Each file becomes a new blog post.

* **Styling:**
  Tailwind is configured by default to run on build. Modify styles according to the Tailwind docs. Entry point is `wwwroot/css/app.css`. (You can also cheat and add utility classes to an unused component, as I've done in `Components/Palette.razor`.)

* **Layout:**
  Site layout is very simple and is in `Layouts/MainLayout.razor`. Additional components can be created in the `Components/` folder. Razor files will be created for any folder that contains a `*.md` file and a `template.razor` file.

---

## 📁 Project Structure

```txt
blake-sample-blog/
├── .github/              # GitHub Actions workflows
│   └── workflows/        # CI/CD workflows
│       └── deploy.yml    # Deploy workflow
├── Components/           # Reusable Razor components
├── Layout/               # Main layout and other layouts like navigation
├── Pages/                # Static pages (e.g. about, contact)
├── Posts/                # Your Markdown content (posts, pages)
├── Utils/                # Helpers and extension methods
├── wwwroot/              # Static assets (CSS, images, etc.)
│   ├── css/              # CSS files
│   │   ├── app.css       # Main CSS file
│   │   └── tailwind.css  # Tailwind CSS file
│   └── images/           # Images used in posts or site
│   └── index.html        # Main HTML file
├── _Imports.razor        # Global imports for Razor components
├── App.razor             # Main application entry point
```

---

## 📦 Deployment

This template outputs static files. You can host the result anywhere that serves static sites, e.g.:

* GitHub Pages
* Azure Static Web Apps


Push to your main branch and GitHub Actions will automatically build and deploy.

---

## 📄 License

This project is licensed under the MIT License.
See the [LICENSE](LICENSE) file for details.

---

## 🤝 Contributing

Contributions are welcome!
See [CONTRIBUTING.md](CONTRIBUTING.md) for details.

---

## 🙏 Acknowledgements

* [Blake](https://github.com/matt-goldman/blake)
* [Tailwind CSS](https://tailwindcss.com/)
* [PostCSS](https://postcss.org/)
