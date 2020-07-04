const digit:string[2]='01';
var z:string;
c,l:integer;
begin
  writeln('Введите двоичный код');
  readln(z);
  while z[1]='0' do
    delete(z,1,1);
  c:=0;
  for l:=1 to length (z) do
    c:=c*2+pos(z[l],digit)-1;
  write ('Число в десятичной системе счисления: ',c)
end.