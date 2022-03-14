---
layout: home
permalink: index
---

# Project Idea
### The universe in you room

- You can find planets, nebul and constellations.
- After download and install on your Android device, you can rotate to see what's around you.
- You also can interact with the object. Let the meteorite explode, or connect the stars into a constellation.




# Demo Exhibit

![img](https://github.com/BRANDDY/unityAR/raw/gh-pages/docs/assets/demo.png)

Watch [Full Video](https://drive.google.com/file/d/1GZh5S8cb0CitseI6WiguvvhZbLj8uNk5/view?usp=sharing) Here !


# Project Process

### Future Update

- add more object such as constellations
- add animation and interact system
- Develop Material
- Develop Shader

<!DOCTYPE html>
<html lang="en">
	<head>
		<meta charset="UTF-8"><meta name="viewport" content="width=device-width, initial-scale=1.0">
		<link rel="stylesheet" href="../assets/css/style.css">
		<title>Sample Group Project Site</title>
	</head>
	<center>
		<body>
			<h2>JavaScript Button to AR page</h2>
			<p id="demo">Building Interactive Systems</p>

			<!-- MARKER BASED: MULTI MARKER | PRESET hiro | kanji -->
			<button type="button" onclick="openTab('marker-based/ar-index.html')">Take me to marker-based AR</button>
			<script>
				function openTab(url) {
					const link = document.createElement('a');
					link.href = url;
					link.target = '_blank';
					document.body.appendChild(link);
					link.click();
					link.remove();
				}
			</script>
        </body>
	</center>
</html>
</html>

