﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Revert.Core.Text.NLP
{
    public static class StopList
    {
        private static readonly string rawWords = @"
a
a's
again
ain't
all
am
an
and
are
aren't
as
at
away
b
be
been
but
by
c
c'mon
c's
came
can
can't
cannot
cant
co
com
come
comes
could
couldn't
d
did
didn't
do
does
doesn't
doing
don't
done
e
each
eg
else
elsewhere
enough
et
etc
f
for
g
get
go
goes
got
gotten
h
had
hadn't
having
he
he's
her
hers
herself
hi
him
himself
his
how
i
i'd
i'll
i'm
i've
ie
if
in
is
isn't
it
it'd
it'll
it's
its
itself
j
just
k
know
knows
known
l
let
let's
look
looking
looks
m
me
much
my
myself
n
nd
o
of
off
oh
ok
okay
on
onto
or
our
ours
ourselves
out
over
p
q
que
quite
qv
r
rd
re
s
said
same
saw
say
saying
says
see
seeing
seem
seen
self
selves
she
sub
such
t
t's
tell
tends
th
than
that
that's
thats
the
their
theirs
them
themselves
then
there
there's
theres
these
they
they'd
they'll
they're
they've
this
those
to
too
took
u
un
us
v
very
w
want
wants
was
wasn't
way
we
we'd
we'll
we're
we've
well
went
were
weren't
wherever
whether
which
while
whole
whose
why
with
won't
would
wouldn't
x
y
you
you'd
you'll
you're
you've
your
yours
yourself
yourselves
z
zero
percent
year
years";

        public static HashSet<string> Words { get; set; } = rawWords
     .Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToHashSet();

    }
}
