<?php
$result = null;

if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    $a  = (float)($_POST['a'] ?? 0);
    $b  = (float)($_POST['b'] ?? 0);
    $op = $_POST['op'] ?? '+';

    switch ($op) {
        case '+': $result = $a + $b; break;
        case '-': $result = $a - $b; break;
        case '*': $result = $a * $b; break;
        case '/': $result = ($b == 0) ? 'Cannot divide by zero' : $a / $b; break;
        default:  $result = 'Unknown operation';
    }
}
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>PHP Calculator</title>
    <style>
        body { font-family: Arial, sans-serif; max-width: 480px; margin: 40px auto; }
        input, select, button { padding: 8px; margin: 4px; }
    </style>
</head>
<body>
    <h1>PHP Calculator</h1>
    <p>Student: CHUA WENG KIN (106214072)</p>
    <p>Today: <?= date('d M Y, H:i') ?></p>

    <form method="post">
        <!-- User enters two numbers and selects the calculation operation. -->
        <input type="number" step="any" name="a" required> 
        <select name="op">
            <option value="+">+</option>
            <option value="-">-</option>
            <option value="*">×</option>
            <option value="/">÷</option>
        </select>
        <input type="number" step="any" name="b" required>
        <button type="submit">Calculate</button>
    </form>

    <!-- Shows the result only after a calculation has been performed. -->
    <?php if ($result !== null): ?>
        <h3>Result: <?= htmlspecialchars((string)$result) ?></h3>
    <?php endif; ?>
</body>
</html>
