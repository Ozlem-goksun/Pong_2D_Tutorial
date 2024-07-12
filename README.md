# STEP BY STEP 2D PONG GAME 🏓💥
The best way to learn game mechanics is to practice a lot.I think cloning old games is a great way to get started. This time I cloned Pong game, which was released in 1972. And I used the Unity version 2022.3.16f1 to make this game. By the way I mostly used [Zigurous](https://www.youtube.com/@Zigurous)'s [How to make Pong in Unity (Complete Tutorial) 🏓💥](https://www.youtube.com/watch?v=AcpaYq0ihaM) video to make this game so I thank [Adam Graham](https://github.com/adamgraham) very much :)

## Game Preview
![pongGameGif](https://github.com/Ozlem-goksun/Pong_2D_Tutorial/blob/main/Steps/gameView.gif)
## Scene Setup🎥⚙️
Pong, our second clone game, has a scene with a ball, two paddles and a line dividing the game area.We can start making the game by adding these objects.
</br><b><i>So let's get started and bounce the ball !!!</i>🏓</b>

### Ball Settings ⚪

<table>
  <tr>
    <td>
      <p style="margin-top: 0;">First, let's adjust the main camera settings to increase its field of view so that objects in our game area appear smaller.</p>
      <p>🕹️ At first, we add a <b><i>"2D Object > Sprites > Square"</i></b> to the scene in <b><i>"Hierarchy"</i></b> window.</p>
    </td>
  </tr>
  <tr>
    <td style="vertical-align: top; width: 30%;">
      <img src="https://github.com/Ozlem-goksun/Pong_2D_Tutorial/blob/main/Steps/1-Ball.png" alt="1-Ball" style="max-width: 100%; height: auto;">
    </td>
  </tr>
   <tr>
    <td>
      <p>🕹️ As you can see below, the ball looks too big on the scene when it is first added. Let's fix this first. In the <b><i>"Inspector"</i></b> window you can change the size of the ball by going to the <b><i>"Transform"</i></b> component.</p>
    </td>
  </tr>
   <tr>
    <td style="vertical-align: top; width: 30%;">
      <img src="https://github.com/Ozlem-goksun/Pong_2D_Tutorial/blob/main/Steps/2-Ball_view.png" alt="2-Ball" style="width: 650px; height: auto;">
      <img src="https://github.com/Ozlem-goksun/Pong_2D_Tutorial/blob/main/Steps/3-Ball_size.png" alt="3-Ball" style="max-width: 100%; height: auto;">
    </td>
  </tr>
  <tr>
    <td>
      <p>🕹️ And then add a <b><i>"Rigidbody"</i></b> component so that the ball can behave according to the laws of physics.</p>
      <p>🕹️ Set the <b><i>"Angular Drag"</i></b> and <b><i>"Gravity Scale"</i></b> to <b><i>"0"</i></b> in the <i>"Rigidbody"</i> component. <i>"Angular Drag"</i> controls the object's drag resistance to the speed of rotation.</br>
        The higher the value, the faster the rotation of the object decreases. We don't want the ball to slow down, so we reset the value to <b><i>"0"</i></b>.</p>
      <p>🕹️ In the same way, we set the <b><i>"Gravity Scale"</i></b> to <b><i>"0"</i></b> so that the ball is not affected by gravity.</p>
      <p>🕹️ By the way, freeze the rotation of the ball on the <b><i>Z</i></b>-axis so that it does not move in the 3rd dimension, i.e. on the <b><i>Z</i></b>-axis.</p>
     <p>🕹️ Then add a <b><i>"Box Collider"</i></b> so that the ball can recognize other objects in the game area when it hits them.</p>
    </td>
  </tr>
   <tr>
    <td style="vertical-align: top; width: 30%;">
      <img src="https://github.com/Ozlem-goksun/Pong_2D_Tutorial/blob/main/Steps/4-Ball_add_Rigidbody.png" alt="4-Ball" style="max-width: 100%; height: auto;">
      <img src="https://github.com/Ozlem-goksun/Pong_2D_Tutorial/blob/main/Steps/5-Ball_Set_Rigidbody.png" alt="5-Ball" style="max-width: 100%; height: auto;">
      <img src="https://github.com/Ozlem-goksun/Pong_2D_Tutorial/blob/main/Steps/6-Ball_Add_BoxCollider.png" alt="6-Ball" style="max-width: 100%; height: auto;">
    </td>
  </tr>
  
</table><p><i>So let's go to the next step.</i></p>

### Paddle Settings 🏓
To hit the balls, we need to create two paddles, one managed by us and one managed by the computer.
<table style="margin-left: auto; margin-right: auto;">
  
  <tr>
    <td style="text-align: center;">
      <p>🕹️ Add a square sprite for this like you did when you created the ball.</p>
      <p>🕹️ Add <i>"Rigidbody"</i>. Decrease the <b><i>"Mass"</i></b> value to make it move faster.</p>
      <p>🕹️ Set the <b><i>"Gravity Scale"</i></b> value to <b><i>"0"</i></b> so that it is not affected by gravity.</p>
      <p>🕹️ Set the <b><i>"Angular Drag"</i></b> value to <b><i>"0"</i></b> so that the rotational speeds do not decrease.</p>
      <p>🕹️ You can set the <b><i>"Linear Drag"</i></b> to a value (such as 2) that does not interfere with the ball's movement.</br>
        <i>"Linear Drag"</i> simulates the air resistance an object encounters as it moves. Giving paddles a <i>"Linear Drag"</i> value makes their movement more controlled and realistic.</p>
      <p>🕹️ Paddles should only move up and down, so we have to freeze their rotation in the <b><i>"X"</i></b> and <b><i>"Z"</i></b> axis.</p>
    </td>
  </tr>
  
  <tr>
    <td style="text-align: center;">
      <img src="https://github.com/Ozlem-goksun/Pong_2D_Tutorial/blob/main/Steps/7-Paddle_Set_Rigidbody.png" alt="7-Paaddle" style="max-width: 100%; height: auto;">
      <img src="https://github.com/Ozlem-goksun/Pong_2D_Tutorial/blob/main/Steps/8-Paddle_Size.png" alt="8-Paaddle" style="max-width: 100%; height: auto;">
    </td>
  </tr>
  
  <tr>
    <td style="text-align: center;">
      <p>🕹️ After these steps, your scene should look like this 👇🏽.</p>
    </td>
  </tr>
  
  <tr>
    <td style="text-align: center;">
      <img src="https://github.com/Ozlem-goksun/Pong_2D_Tutorial/blob/main/Steps/29-Paddle-View.png" alt="29-Paddle_view" style="max-width: 100%; height: auto;">
    </td>
  </tr>
  </table>


  <table>
    <tr>
        <td style="text-align: left;">
          <p style="margin-top: 0;">Now we need to surround the game area with invisible walls so that the ball doesn't go out of the game. We can do this with a single rectangular jammer, 
            but in this game the ball should bounce when it hits up and down, and when it hits left and right it should affect the players' scores, so we need four walls that are separate from each other.</p>
        </td>
      </tr>
      <tr>
        <td style="vertical-align: top; text-align: center;">
          <img src="https://github.com/Ozlem-goksun/Pong_2D_Tutorial/blob/main/Steps/9-Wall.png" alt="9-Wall" style="width: 450px; height: auto; display: block; margin: 0 auto;">
          <img src="https://github.com/Ozlem-goksun/Pong_2D_Tutorial/blob/main/Steps/10-Walls.png" alt="10-Wall" style="width: 450px; height: auto; display: block; margin: 0 auto;">
        </td>
      </tr>
      
</table>

 <table style="margin: 0 auto;">
  <tr>
    <td style="text-align: center;">
      <p style="margin-top: 0;">🕹️ </p>
      <p style="margin-top: 0;">🕹️ </p>
       <p> </p>
    </td>
  </tr>
  <tr>
    <td style="text-align: center;">
      <img src="https://github.com/Ozlem-goksun/Pong_2D_Tutorial/blob/main/Steps/11-Line.png" style="max-width: 100%; height: auto; display: inline-block; margin: 0 auto;">
      <img src="https://github.com/Ozlem-goksun/Pong_2D_Tutorial/blob/main/Steps/12-Line_settings.png" style="max-width: 100%; height: auto; display: inline-block; margin: 0 auto;">
      <img src="https://github.com/Ozlem-goksun/Pong_2D_Tutorial/blob/main/Steps/13-Line_Material.png" style="max-width: 100%; height: auto; display: inline-block; margin: 0 auto;">
      <img src="https://github.com/Ozlem-goksun/Pong_2D_Tutorial/blob/main/Steps/14-Line_Material_2.png" style="max-width: 100%; height: auto; display: inline-block; margin: 0 auto;">
      <img src="https://github.com/Ozlem-goksun/Pong_2D_Tutorial/blob/main/Steps/15-Line_Material_3.png" style="max-width: 100%; height: auto; display: inline-block; margin: 0 auto;">
      <img src="https://github.com/Ozlem-goksun/Pong_2D_Tutorial/blob/main/Steps/16-Line_Material_4.png" style="max-width: 100%; height: auto; display: inline-block; margin: 0 auto;">
      <img src="https://github.com/Ozlem-goksun/Pong_2D_Tutorial/blob/main/Steps/17-Line_Material_5.png" style="max-width: 100%; height: auto; display: inline-block; margin: 0 auto;">
      <img src="https://github.com/Ozlem-goksun/Pong_2D_Tutorial/blob/main/Steps/18-Line_Material_6.png" style="max-width: 100%; height: auto; display: inline-block; margin: 0 auto;">
      <img src="https://github.com/Ozlem-goksun/Pong_2D_Tutorial/blob/main/Steps/19-Line_Material_7.png" style="max-width: 100%; height: auto; display: inline-block; margin: 0 auto;">
      <img src="https://github.com/Ozlem-goksun/Pong_2D_Tutorial/blob/main/Steps/20-Scene_View.png" style="max-width: 100%; height: auto; display: inline-block; margin: 0 auto;">
    </td>
  </tr>
    <tr>
    <td style="text-align: center;">
      <p style="margin-top: 0;">🕹️ </p>
    </td>
  </tr>
  <tr>
    <td style="text-align: center;">
      <img src="https://github.com/Ozlem-goksun/Pong_2D_Tutorial/blob/main/Steps/21-Scripts.png" style="max-width: 100%; height: auto; display: block; margin: 0 auto;">
      <img src="https://github.com/Ozlem-goksun/Pong_2D_Tutorial/blob/main/Steps/21-Scripts_2.png" style="max-width: 100%; height: auto; display: block; margin: 0 auto;">
      <img src="https://github.com/Ozlem-goksun/Pong_2D_Tutorial/blob/main/Steps/21-Scripts_3.png" style="max-width: 100%; height: auto; display: block; margin: 0 auto;">
    </td>
  </tr>

<tr>
    <td style="text-align: center;">
      <p style="margin-top: 0;">🕹️ </p>
    </td>
  </tr>
  <tr>
    <td style="text-align: center;">
      </br><p style="margin-top: 0;">🕹️ </p>
    </td>
  </tr>
  <tr>
    <td style="text-align: center;">
      <img src="https://github.com/Ozlem-goksun/Pong_2D_Tutorial/blob/main/Steps/22-Physics_Material.png" style="max-width: 100%; height: auto; display: block; margin: 0 auto;">
      <img src="https://github.com/Ozlem-goksun/Pong_2D_Tutorial/blob/main/Steps/22-Physics_Material_Bouncy_settings.png" style="max-width: 100%; height: auto; display: block; margin: 0 auto;">
      <img src="https://github.com/Ozlem-goksun/Pong_2D_Tutorial/blob/main/Steps/23-Physics_Material_Bouncy_settings.png" style="max-width: 100%; height: auto; display: block; margin: 0 auto;">
      <img src="https://github.com/Ozlem-goksun/Pong_2D_Tutorial/blob/main/Steps/24.png" style="max-width: 100%; height: auto; display: block; margin: 0 auto;">
    </td>
  </tr>
  </table>
<p></p>
  <table>
 <tr>
    <td style="text-align: center;">
      <img src="https://github.com/Ozlem-goksun/Pong_2D_Tutorial/blob/main/Steps/25-GameManager.png" style="max-width: 100%; height: auto; display: block; margin: 0 auto;">
      <img src="https://github.com/Ozlem-goksun/Pong_2D_Tutorial/blob/main/Steps/26-Base_Event.png" style="max-width: 100%; height: auto; display: block; margin: 0 auto;">
      <img src="https://github.com/Ozlem-goksun/Pong_2D_Tutorial/blob/main/Steps/27-Base_Event_2.png" style="max-width: 100%; height: auto; display: block; margin: 0 auto;">
      <img src="https://github.com/Ozlem-goksun/Pong_2D_Tutorial/blob/main/Steps/28-scoreText.png" style="max-width: 100%; height: auto; display: block; margin: 0 auto;">
      <img src="https://github.com/Ozlem-goksun/Pong_2D_Tutorial/blob/main/Steps/29-Paddle-View.png" style="max-width: 100%; height: auto; display: block; margin: 0 auto;">
    </td>
  </tr>
  </table>
  
  ## Snake Movement 🐍🤸🏻‍♀️

  <p>Now that our game area is ready, we can start to move the snake. Of course, we will give the snake movement using code. <b><i>So let's move on.</i></b></br></p>
  
  <table>
 <tr>
    <td style="text-align: center;">
      <p style="margin-top: 0;">🕹️ As you know, we will add mechanics to objects using <b><i>"C#"</i></b>. For this, first we need to create a <b><i>"C# Script"</i></b> file in the <b><i>"Assets"</i></b> folder.</p>
    </td>
    </tr>
      <tr>
      <td style="text-align: center;">
      <img src="https://github.com/Ozlem-goksun/Snake2D_Unity_Tutorial/blob/main/Steps_ss/step_6.png" alt="step3_6" style="max-width: 100%; height: auto; display: block; margin: 0 auto;">
    </td>
     </tr>
    <tr>
    <td style="text-align: center;">
      <p style="margin-top: 0;">🕹️ In order for the script to affect the snake object, it must be added as a component to the snake object.</p>
    </td>
    </tr>
      <tr>
      <td style="text-align: center;">
      <img src="https://github.com/Ozlem-goksun/Snake2D_Unity_Tutorial/blob/main/Steps_ss/step_6_2.png"  style="max-width: 100%; height: auto; display: block; margin: 0 auto;">
    </td>
     </tr>
 </table>

<p>Now it's time to open the script. When you first open the script you will see code blocks like this by default. We will add new libraries (using System.....) depending on the commands we write in the code. 
  For now, the libraries given below will be more than enough.</p>


  ### Eating Food 🍎


#### There seems to be nothing left to do. For now.
### See you in more advanced versions of the game.
# Good luck with the food hunt🐍🍎.
