#set align(center)
#set text(
  font: "Times New Roman",
  size: 32pt
)
CMP3754 Virtual and Augmented Reality Report

Newton Splash

#set text(
  size: 16pt
)
Vishal Maisuria - 26439978

Word Count: 1447
#set align(left)
#pagebreak()
#outline()
#pagebreak()

#set heading(numbering: "1.1.")
= Introduction: 761 words
#set text(size: 14pt)
I developed an AR-based game in Unity, called Newton Splash. The aim of the game involved apple throwing, which contributed to the score by one, and I planned to implement a way to earn more points by hitting specific machines in Isaac Newton Building. Trophies were also availble to be achieved, for specific actions, for example after achieving a score of 30. I also developed an interactive menu system, to enhance immersion and enjoyment. The primary focus was ensuring the mechanics and user interface were optimised for augmented reality while maintaining efficient gameplay. 

The main part of the game was the apple throwing mechanic, while relied on Unity's Rigidbody physics system. As this game is for mobile devices, the velocity was determined through the swiping upwards actions by users. To enhance realism and effectiveness, I implemented an adjustable force multiplier based on the speed of swiping, to ensure users could control the throw distance and angle. The targets that I set as "special" which awarded more points were programmed with colliders, which registered hits and therefore awarded points. To verify this, and also give more information to the user, visual updates were integrated, a score count displayed in real time to the user on the gameplay screen. This UI element needed to remain anchored and visible in the AR space on the mobile device, and I achieved this by using Unity's canvas, which ensured in stayed non-intrusive and within view.

Adding a pause menu was essential in order to maintain user immersion and enjoyment. The function of halting the game is important for most people, considering that life is filled with interruptions and you just want to be able to pick up where you left of without much hassle @nooh_ux_2023. To implement the pause menu, I created a new scene in Unity, and then linked it to the gameplay scene through the use of buttons. Organising the buttons was simple, as I required the buttons to be unobtrusive to the user but still accessible, which is why I positioned the button on the top left of the screen, where it is unlikely to interfere with the normal gameplay. The game timer stops when the pause menu is accessed, and is resumed if the user selects to reume the game. Implementing this into my game was essential to result in a seamless transition between gameplay and the pause menu. Here in the pause menu, the user can still view their score, but also return to the main menu, if they decide to quit the game. This removes the unattractive aspect of a game where you have to deliberately "die" to quit.

Including haptic feedback through vibrations into my game is a great way to stimulate user's sense of touch, resulting in a more immersive exeperience and an increase in user satisfaction. Haptic feedback can create profound sensory interactions, linking users more cohesively with the digital world @gruver_embracing_2023. I implemented a light vibration, which occurred when an apple was thrown, giving a tactile response, complimenting the visual elements in the game. This was very benefical, as it not only helped with immersion, but also supported the actions, confirming that an apple was released. 

The AR environment that I used for the game was through Unity's XR Toolkit. Anchors were used to keep objects, like menus, stable within the screen and during movement. Ensuring the appropriate design of these objects was imperative to ensure that buttons, objects and menus did not appear distracting or unnattractive during gameplay, where the conditions of the screen may vary drastically depending on real world situations. The Toolkit is great for future development, as it is modular and is able to implement cross-platform compatibility, which is efficient as opposed to creating separate SDKs.  
== Reflection
There were some challenges that I encountered during my development, which did set me back in the process. Initially, I had an issue where I was unable to test my project on the mobile device, which was resolved by using another cable. As I had never used AR features on Unity, and also new to Unity as a whole, it did take me longer to figure out the process of development. There were also some issues with the merging of all the elements on the screen, where there would be a grey hue to the screen as a result of the plane, but this was resolved by editing the alpha values. The combination of the gameplay with the score text and pause button was also a problem, as these would dissapear at times. 

#pagebreak()

= Report: 686 words
The design choices that I made during development and testing were informed and considerate of many factors, including the properties that a game should include that will improve user experience and immersion, along with external factors, including my experience with Unity and the AR functions, as well as the time that I had to complete this project within. 

The choices I made in terms of interactive feedback were deliberately combined to create a multisensory experience between visual and haptic feedback. Users who receive multi-sensory feedback report a higher sense of presence and realism compared to those who recevive single sensory feedback @ahmad_influence_2024. Having a high sense of realism and presence is beneficial in an augmented reality application, as this blends the line between reality and the game, improving experience and satisfaction. The placement of UI elements, like buttons and score text were positioned in such a way as not to interefere with the main gameplay, but also accessible for the user to view and interact with. Placing these elements directly in gameplay was avoided as this would dirsupt user's immersion @noauthor_ui_nodate, conflicting with the aim of the game resulting in a lower user satisfaction and negative user experience. As a result, buttons and text and notifications were positioned in the top corners of gameplay, as the position of hands would interfere with lower reading of text. Buttons were also coloured brightly to be obvious to the user, with the colours changing when the user presses on them, giving user feedback that the button has been registered as "pressed".

I chose touch based controls for the apple-throwing mechanics, with speed based on how fast the user would swipe the apple. Using these gesture based inputs for the game were intuitive for mobile games, as gestures are a natural way for people to interact with the world around them. As such, they are expected to be well-integrated and accepted as an interaction method in AR systems @gavgiotaki_gesture-based_2023.

== Critique of Design Choices
I believe I have created an simple and engaging AR application that integrates multiple methods of feedback that are effective. The game is easy to understand and play, and the UI elements are clear without detracting from the gameplay. Menus are informative without overwhelming the user.

On the other hand, there are aspects of the game that could be improved. Due to restrictions, I was unable to completely implement an interface that is appealing to the eye, and audio feedback, which would immerse the user even more and increase user satisfaction. There is no settings menu, which would be beneficial as this could include options that would help the user tailor the experience to themselves. Additionally, the nature of this game is not ideal for those with mobility issues, as moving around Isaac Newton Building is necessary to gain more points. While this is possible for those in wheelchairs and such, those with visual or motor impairments could benefit from settings that cater to these differences.  

The gameplay could also be improved in a number of ways. I was unable to implement the aspect where hitting specific objects would gain more points. Implementing this in the future would have been beneficial and given an objective to the game. This could also tie into implementing a leaderboard, with users battling with one another in order to achieve the highest score. Although having a multiplayer aspect to the game may decrease immersion @cairns_who_2013, it will increase the satisfaction and enjoyment that the user will have while playing the game. To go along with increasing the length of gameplay, it would also be a positive addition to include more trophies and objectives for the user to achieve, as this will not only give the user an objective for the game, but many different objectives, possibly hidden, that the user can look out for. This could include trophies that are fairly easy to achieve, but then also hidden ones, that users can spend time decoding and as a result learn more about Isaac Newton building and the University as a whole. 

Comparatively, Newton splash focusses on a user-centered AR experience with apple-throwing mechanics, unlike socially driven games like Pokemon GO. Incorporating progression systems, such as levels, and periodic events could boost user engagement and satisfaction, enhancing the game experience.



























#pagebreak()
#bibliography("AR report.bib", style: "university-of-lincoln-harvard.csl", title: [References])