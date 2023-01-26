<?php

echo "#1" . PHP_EOL;
echo "#2" . PHP_EOL;
echo "#3" . PHP_EOL;
echo "#4" . PHP_EOL;
echo "#5" . PHP_EOL;
echo "#6" . PHP_EOL;
echo "#7" . PHP_EOL;
echo "#8" . PHP_EOL;
echo "#9" . PHP_EOL;
echo "#10" . PHP_EOL;
echo "#11" . PHP_EOL;
echo "#12" . PHP_EOL;
echo "#13" . PHP_EOL;
echo "#14" . PHP_EOL;
echo "#15" . PHP_EOL;

$contador = 1;

#enquanto nao chegar a 15
        echo $contador . PHP_EOL;
        $contador = $contador + 1;

        $contador = 1;

        while ($contador < 15) {
                echo "#$contador" . PHP_EOL;
                $contador = $contador + 1;
        }

        $contador = 1;

while ($contador <= 15) {
        echo "#$contador" . PHP_EOL;
        // $contador = $contador + 1;
}


for ($contador = 1; $contador <= 15; $contador ++) 
    echo "#$contador" . PHP_EOL;