import turtle
import math
import random

def color():
   colorm=random.randint(1,4)
   if colorm==1:
       return "limegreen"
   elif colorm==2:
       return "yellowgreen"
   elif colorm==3:
       return "darkgreen"
   else:
       return "green"
def color2():
   colorm=random.randint(1,3)
   if colorm==1:
       return "pink"
   elif colorm==2:
       return "lightpink"
#    elif colorm==3:
#        return "salmon"
   else:
       return "hotpink"

def circle(n):
    turtle.begin_fill()
    pencolor=color()
    turtle.pencolor(pencolor)
    turtle.fillcolor(pencolor)
    for i in range (n):
       turtle.forward(1)
       turtle.right(360/n)
       turtle.forward(3)
       turtle.right(80)
       turtle.forward(3)
       turtle.left(80)
    turtle.pencolor("brown")
    turtle.end_fill()

def circle2(n):
    turtle.begin_fill()
    pencolor2=color2()
    turtle.pencolor(pencolor2)
    turtle.fillcolor(pencolor2)
    for i in range (n):
       turtle.forward(1)
       turtle.right(360/n)
       turtle.forward(3)
       turtle.right(80)
       turtle.forward(3)
       turtle.left(80)
    turtle.pencolor("brown")
    turtle.end_fill()         

# r=zav
# w=pensize
def simple_tree(d,r,w):
    if d<10 :
        circle(6)
        return
    turtle.pencolor("brown")
    turtle.pensize(w)
    turtle.forward(d)
    turtle.left(r)
    simple_tree(d * (random.random()/2+ 0.5), 
                r* (random.random()/2 + 0.8), 
                w * (random.random()/2 + 0.5))
    turtle.right(r*2) 
    simple_tree(d * (random.random()/2 + 0.5), 
               r * (random.random()/2 + 0.8), 
               w * (random.random()/2 + 0.5))
    turtle.left(r)
    turtle.penup()
    turtle.backward(d)
    turtle.pendown()
def simple_tree2(d,r,w):
    if d<9:
        circle2(6)
        return
    turtle.pencolor("brown")
    turtle.pensize(w)
    turtle.forward(d)
    turtle.left(r)
    simple_tree2(d * (random.random()/2+ 0.5), 
                r* (random.random()/2 + 0.8), 
                w * (random.random()/2 + 0.5))
    turtle.right(r*2) 
    simple_tree2(d * (random.random()/2 + 0.5), 
               r * (random.random()/2 + 0.8), 
               w * (random.random()/2 + 0.5))
    turtle.left(r)
    turtle.penup()
    turtle.backward(d)
    turtle.pendown()
def setup_screen(width, heigh):
    turtle.left(90)
    turtle.pencolor("brown")
    turtle.tracer(0)
    turtle.hideturtle()
    turtle.screensize(width, heigh)
    turtle.bgcolor("navajowhite")
width, height = 1800, 1000
x=-800
y=-800
setup_screen(width, height)
tree_count = 16
for ـ in range(tree_count):
    x += random.randint(80, 130)
    y = random.randint(-140,20)
    turtle.penup()
    turtle.setpos(x, y)
    turtle.pendown()
    # fl(random.randint(70,230))
    ran=random.randint(1,2)
    if ran==2:
      simple_tree(
        random.randint(45, 70), 
        random.randint(20,35), 
        random.randint(3,8))
    else:
        simple_tree2(
        random.randint(25, 70), 
        random.randint(20,35), 
        random.randint(3,8))
    turtle.update()
turtle.tracer(0)
turtle.penup()
turtle.setpos(-1800,-100)
turtle.pendown()
turtle.pencolor("limegreen")
turtle.fillcolor("limegreen")
turtle.begin_fill()
for _ in range (4):
    turtle.right(90)
    turtle.forward(4000)
turtle.end_fill()
def colorf():
   colorm2=random.randint(1,3)
   if colorm2==1:
       return "deeppink"
   elif colorm2==2:
       return "red"
   else :
       return "orange"
def aft():
    for i in range(14):
        turtle.forward(30)
        turtle.left(150)
def flower(x,y):
  for _ in range (50):
    turtle.penup()
    turtle.setpos(x,y)
    turtle.pendown()
    randc=colorf()
    turtle.pencolor(randc)
    turtle.fillcolor(randc)
    turtle.begin_fill()
    aft()
    turtle.end_fill()
    turtle.penup()
    x+=random.randint(40,100)
    y=random.randint(-300,-110)
flower(-500,-170)
turtle.update()
turtle.mainloop()



















































