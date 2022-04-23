

# Project Idea

In light-polluted environments, stars are hard to see with the naked eye.
And also galaxy and planets need professional equipment to watch.
###What the universe looks like and what it's like to be surrounded by stars.###
This homework is made up of my yearning and imagination for the universe。

# What you can find

- The planets revolves around you.
- Colorful nebula, and meteors.
- When a constellation turned in front of you, the stars will be line up.
- After download and install on your Android device, you can rotate to see what's around you.



# Demo Exhibit

![img](https://github.com/BRANDDY/unityAR/raw/gh-pages/docs/assets/demo.png)

Watch [Full Video](https://drive.google.com/file/d/1GZh5S8cb0CitseI6WiguvvhZbLj8uNk5/view?usp=sharing) Here !


<html lang="en">
	<head>
		<meta charset="UTF-8"><meta name="viewport" content="width=device-width, initial-scale=1.0">
	</head>
	<center>
		<body>
			<h2>JavaScript Button to AR page</h2>
			<p id="demo">Building Interactive Systems</p>

			<!-- MARKER BASED: MULTI MARKER | PRESET hiro | kanji -->
			<button type="button" onclick="openTab('./ar-index.html')">Take me to marker-based AR</button>
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
			<!-- MARKER BASED: MULTI MARKER | PRESET hiro | kanji -->
			<button type="button" onclick="openTab('./test.html')">location-based AR</button>
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
