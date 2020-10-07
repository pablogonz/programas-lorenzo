# MCD sin tail recursion 
a= int(input(" introduzca un numero "))
b= int(input(" introduzca otro numero "))
def MCD(a, b):
    r=a%b
    if r==0:
        return b
    
    return MCD(b,r)
print (MCD(a,b))