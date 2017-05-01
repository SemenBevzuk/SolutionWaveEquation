import pylab
from mpl_toolkits.mplot3d import Axes3D
import numpy
import os

def makeDataFromFile ():
    cwd = os.getcwd()
    print(cwd)
    os.chdir('../')
    cwd = os.getcwd()
    print(cwd)
    file = open('out.csv', 'r');

    s = file.readline()
    array = s.split(';', 1)
    array[1] = array[1].replace("\r\n", '')
    n = int(array[0])
    m = int(array[1])

    x = numpy.empty((m,n))
    y = numpy.empty((m,n))
    z = numpy.empty((m,n))
    i = 0;
    j = 0;

    for line in file:
        array_coord = line.split(';', 2)
        array_coord[2] = array_coord[2].replace("\r\n", '')
        x[j,i] = float(array_coord[0])
        y[j,i] = float(array_coord[1])
        z[j,i] = float(array_coord[2])
        i = i + 1
        if  i==n:
            j = j+1
            i = 0

    x.reshape(n,m);
    y.reshape((n,m));
    z.reshape((n,m));
    return x, y, z

x, t, u = makeDataFromFile()

fig = pylab.figure()
axes = Axes3D(fig)
axes.plot_surface(x, t, u)
pylab.xlabel('x')
pylab.ylabel('t')
pylab.grid(True)
pylab.show()

