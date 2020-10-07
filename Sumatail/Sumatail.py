
#Sumatoria usando tail recursion
from tco import * 
n= int(input(" introduzca un limite "))


@with_continuations()
def Suma(n, k, self=None):
    return self(n - 1, n + k) if n > 1 else k 

print (Suma(n,1))