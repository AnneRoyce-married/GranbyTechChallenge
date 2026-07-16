# GranbyTechChallenge

This project is a solution to a warehouse packing and stock allocation challenge.

A warehouse receives different types of packing orders (jobs), where each job is created from a predefined template (bundle). Each template requires a fixed quantity of stock items.

For example:

Job Required Stock
Birthday Gift 1 × Key Ring, 2 × Controller, 1 × Box
Christmas Gift 3 × Xbox Games, 1 × Bubble Wrap, 1 × Box

Multiple templates can share the same stock items, while the warehouse maintains only a finite inventory.

Orders are received throughout the day and must be dispatched within either 24 or 48 hours.

Problem

Given:

A collection of stock items and their available quantities.
Multiple order batches arriving at different times.
Templates defining the stock required for each job.

Determine:

A. Fulfilled Orders

How many orders can be completed using the available stock?

B. Stock Shortfall

For the remaining unfulfilled orders, calculate the shortage of each stock item required to complete them.

Fulfilment Strategies

The application is designed so different allocation strategies can be plugged in without changing the core processing logic.

Current strategies include:

1. First In First Out (FIFO)

Orders are fulfilled in the order they were received.

2. In Full

Maximise the total number of completely fulfilled orders using the available stock.

3. On Time In Full (OTIF)

Prioritise fulfilling orders completely while also respecting dispatch deadlines.

