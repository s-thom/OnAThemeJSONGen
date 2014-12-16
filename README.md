OnAThemeJSONGen
---

JSON variation generator for Minecraft.  
Originally created to be used with my pack: [On a Theme](http://secretonline.co/minecraft/textures/on-a-theme).

Making variatons in Minecraft is tedious. As well as actually creating the textures, you need to create the models and add them to the blockstates. Luckily, you can inherit the models, and use different textures. Even so, you need to copy/paste files, and change only a couple of things inside them. This was starting to get annoying, so I decided to write this program.

At a very high level, what you do is tell it is that you want `x` variations of `block`.  
At a lower level, you need to know the particular variants (e.g. `half=upper` or `facing=west`), the textures, and how they're refered to in the model files (e.g. `bottom` or `cross`).

[Releases](https://github.com/SecretOnline/OnAThemeJSONGen/releases)

Instructions: [github.io](http://git.secretonline.co/OnAThemeJSONGen#usage)

To Do:
---

1. ~~Tidy it up. (It needs serious cleaning. I'm sure there's a far better way to do a lot of this.)~~
2. ~~Attributes system. (e.g. "half=upper" and hopefully be able to handle things such as "alt=false,east=false,flip=false,north=false,south=false,upper=0,west=false". The fire file is massive.~~
3. ~~Add more model types, hopefully being able to support every block in the game.~~
4. More customizability. 
5. Save and load configurations.
