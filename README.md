# Blake Sample Blog Template – Tailwind

A clean and minimal starter template for building Markdown-powered blogs with the [Blake](https://github.com/matt-goldman/blake) static site generator.
Styled with [Tailwind CSS](https://tailwindcss.com/) and ready to deploy.

## Demo

You can see a live demo of this template at [Blake Simple Tailwind Sample](https://matt-goldman.github.io/BlakeSimpleTailwindSample).

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

1. **Create a new blake site from the template:**

   ```bash
   blake new --template tailwind-sample
   ```
   (see Blake docs for more details on the `blake new` command)

   Alternatively, you can clone this repository directly:

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

This template includes a GitHub Actions workflow for deploying to GitHub Pages. The workflow is defined in `.github/workflows/deploy-pages.yml`, it builds and deploys the site automatically when you push to the main branch.

If you have cloned this repository, or created this with `blake new`, you can push to your GitHub repository and the workflow will handle the deployment as it integrates with GitHub Pages automatically. You will have to complete the following setup steps:

1. Enable GitHub Pages in your repository settings.
2. In the workflow file, ensure the `base` tag in `index.html` is set correctly for your repository name. The default is set to `BlakeSimpleTailwindSample`, but you can change it to match your repository name.
3. Push your changes to the main branch.
4. The GitHub Actions workflow will automatically build the site and deploy it to the `gh-pages` branch.

As a Blake site is just a static site, you can also deploy it to any static hosting service like Azure, Netlify, Vercel, Cloudflare, or even a simple web server. Most of these are free! 

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
