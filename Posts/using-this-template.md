---

title: "Using This Blog Template (And What It Teaches You About Blake)"
date: 2024-11-30
description: "A walkthrough of how this template works and what it demonstrates about building with Blake."
tags: [template, blake, ssg]
author: Jane Dev
authorTitle: Developer Advocate
avatar: "/images/authors/jane.jpg"
featured: true
---

This post explains how this simple blog template works — and more importantly, how it demonstrates the power and philosophy behind **Blake**.

Blake is all about keeping things simple. This template embraces that. There's no magic. No complicated framework-specific features. Just plain Razor, Markdown, and convention over configuration.

## Features Demonstrated

### 🧩 Uses Tailwind 4

The styling here is powered by Tailwind CSS v4. The CSS is built via `npm run build:css`, and the layout is responsive out of the box.

### 📄 Markdown Content

As with any Blake site, the content is written in Markdown. This template uses the Blake CLI to render posts and pages.

### ✨ Custom Container Renderers

This template **disables Blake's default container renderers** using the flag:

```bash
blake bake --disableDefaultRenderers
# or
blake bake -dr
```

This is important because Blake’s default renderers depend on Bootstrap. This template instead includes its **own container renderers** in the `Components/` folder.

You can also **pass arguments to containers**, like this:

```markdown
:::warning Title="Custom containers may not work"
If you are using custom containers, they might not work as expected in the new API setup. You may need to adjust your dependency injection configuration.
:::
```

Which gets rendered as:

```razor
<WarningContainer Title="Custom containers may not work">
  <p>If you are using custom containers, they might not work as expected in the new API setup. You may need to adjust your dependency injection configuration.</p>
</WarningContainer>
```

### Automatic Build Tasks

This template includes a few handy build tasks that are run automatically:

- **CSS Build**: The Tailwind CSS is built automatically when you run the project.
- **Blake Build**: The `blake bake` command generates the static site from your Markdown files.

These are managed as MS Build tasks in the `.csproj` file, so you can run them with `dotnet build` or directly from Visual Studio.

```xml
<Target Name="BuildTailwind" BeforeTargets="Build">
    <Exec Command="npm run build:css" />
</Target>
<Target Name="BlakeBake" BeforeTargets="Build">
    <Exec Command="blake bake -dr" />
</Target>
```

### 🖼️ Images

Images are nothing special, just handled like any other Blazor project and markdown content. The `wwwroot` folder is used for static assets, and images can be referenced directly in your Markdown files:

```markdown
![My Image](/images/my-image.jpg)
```

The Blake `PageModel` has an explicit `Image` property. This is set in the front matter of posts, then consumed in the `PostCard` component:

```markdown
title: "What is Dependency Injection?"
date: 2024-11-08
description: "A beginner-friendly guide to understanding DI in C#."
tags: [csharp, di, fundamentals]
author: John Code
avatar: "/images/authors/john.jpg"
image: "/images/posts/di.png"
```

And then:

```razor
<img src="@@(Page.Image ?? "https://placeholder.pics/svg/300x192/DFEEF6-B6BEC3/000000")" alt="Post image" class="w-full h-48 object-cover">
```

The same applies to the author avatar, which is pulled from the post metadata (see below).

### 🧭 Dynamic Navigation and Content Indexing

Blake generates a **content index** for all your pages and posts. This template uses that to:

* Dynamically build the navigation menu
* List recent posts on the home page

This is done using a simple `foreach` loop — no special API required.

### 🔍 Metadata Extensions

The Blake `PageModel` has some specific properties. Anything in the front matter that matches them is assigned to those properties. But anything else is still available in the `Metadata` dictionary.

This template adds a small **metadata extension** helper that lets you extract metadata from front matter easily:

```csharp
public static string GetValueOr(this IDictionary<string, string> metadata, string key, string fallback)
```

This is used by the `<Author>` component to pull author name, title, and avatar from each post:

```csharp
_authorName = Page?.Metadata.GetValueOr("author", "Unknown Author");
// ...
```

### 🧪 Bonus: Minimal by Design

There’s very little here — on purpose. This template is intentionally simple, so you can:

* Use it as a clean base
* Understand what’s going on
* Extend it however you like

If you're new to Blake, this template is a great place to start tinkering.

---

Happy building!
