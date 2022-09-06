print('Exercicio 1 ->')
function calculation (n)
  if n == 0 then return 0 end
	return n + calculation(n - 1)
end
print('digite um numero:')
y = io.read()
print('Resultado:')
print(calculation(y))

-----------------------------
print('Exercicio 2 ->')
a = {}
for i=1,100 do
  a[i] = math.random(1, 1000)
end

print('valores:')
for i=1,100 do
  print(a[i])
end

