<?php
fscanf(STDIN, "%d %d %d", $n, $m, $a);

$tilesN = intdiv($n + $a - 1, $a);
$tilesM = intdiv($m + $a - 1, $a);

echo $tilesN * $tilesM;
