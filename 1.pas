var
  m: array[1..100] of integer;
  v: longint;
  j, k: integer;

begin
  writeln('Введите десятичное число');
  readln(v);
  k := 0;
  if v = 0 then
  begin
    k := 1;
    m[k] := 0;
  end else
    while v <> 0 do
    begin
      inc(k);
      m[k] := v mod 2;
      v := v div 2;
    end;
  for j := k downto 1 do write(m[j], ' ');
  readln;
end.