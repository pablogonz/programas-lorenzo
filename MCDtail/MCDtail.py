#MCD Con tail recursion def gcd(a,b):
from tco import *
a= int(input(" introduzca un numero "))
b= int(input(" introduzca otro numero "))

@with_continuations()
def gcd(a,b,self=None):
    r=a%b
    if r==0:
        return b
    elif r==1:
        return 1
    return gcd(b,r)

print(gcd(a,b))
